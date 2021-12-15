using GD.ScriptableTypes;
using GD.Selection;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

/// <summary>
/// Supports click to select and click to set waypoint on a mav mesh
/// NOTE: edited to remove the need for player selection 
/// </summary>
/// <see cref="https://www.youtube.com/watch?v=CHV1ymlw-P8"/>
/// <seealso cref="https://www.youtube.com/watch?v=FkLJ45Pt-mY&t=158s"/>

namespace ARVR.Controllers
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class CharacterNavigationController : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("Set the game object used to indicate a waypoint for the character using this controller for navigation.")]
        private GameObject waypointPrefab;

        [SerializeField]
        [Tooltip("Used by the waypoint when the character is moving. Can be simple empty object.")]
        private GameObject sceneAnchor;

        [Header("Selected Object Buffer")]
        [SerializeField]
        [Tooltip("A scriptable object which holds a reference to the currently selected character")]
        private GameObjectVariable currentlySelectedGameObject;

        private Animator animator;
        private NavMeshAgent navMeshAgent;
        private IRayProvider rayProvider;
        private ISelector selector;
        private RaycastHit hitInfo;

        private void Start()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            rayProvider = GetComponent<IRayProvider>();
            selector = GetComponent<ISelector>();
            animator = GetComponent<Animator>();
        }

        /// <summary>
        /// Called when player selects a destination point on the navmesh
        /// </summary>
        /// <param name="context"></param>
        public void OnSelectWaypoint(InputAction.CallbackContext context)
        {
            //determine destination
            ClickDestination();
        }

        /// <summary>
        /// Move selected player towards active destination point
        /// </summary>
        private void Update()
        {
            if (Vector3.Distance(navMeshAgent.destination, transform.position) <= navMeshAgent.stoppingDistance)
            {
                ClearWaypoint();
                animator.SetBool("IsWalking", false);
            }
        }

        #region Actions -  Set/Clear destination and waypoint

        /// <summary>
        /// Sets navmesh target
        /// </summary>
        /// <param name="target"></param>
        private void SetDestination(Vector3 target)
        {
            navMeshAgent.SetDestination(target);
        }

        /// <summary>
        /// Tests if selector ray intersects with valid destination target
        /// </summary>
        private void ClickDestination()
        {
            selector.Check(rayProvider.CreateRay());
            if (selector.GetSelection() != null)
            {
                hitInfo = selector.GetHitInfo();
                SetDestination(hitInfo.point);
                SetWaypoint();
                animator.SetBool("IsWalking", true);
            }
        }

        /// <summary>
        /// Set the next naviagable waypoint
        /// </summary>
        private void SetWaypoint()
        {
            waypointPrefab.SetActive(true);
            waypointPrefab.transform.SetParent(sceneAnchor.transform);
            waypointPrefab.transform.position = navMeshAgent.destination;
        }

        /// <summary>
        /// Disable waypoint indicator and set waypoint transform back to attached player
        /// </summary>
        private void ClearWaypoint()
        {
            waypointPrefab.SetActive(false);
            waypointPrefab.transform.SetParent(transform);
        }

        #endregion Actions -  Set/Clear destination and waypoint

        #region OLD INPUT - Selection

        //private void OnMouseDown()
        //{
        //    if (currentlySelectedGameObject.Value != null && currentlySelectedGameObject.Value != gameObject)
        //    {
        //        currentlySelectedGameObject.Value = null;
        //        SetSelected(false);
        //    }

        //    SetSelected(true);
        //    currentlySelectedGameObject.Value = gameObject;
        //}

        ////private void Update()
        //{
        //    if (Input.GetMouseButtonDown(1) && isSelected)
        //    {
        //        ClickDestination();
        //    }

        //    if (Vector3.Distance(navMeshAgent.destination, transform.position) <= navMeshAgent.stoppingDistance)
        //    {
        //        ClearWaypoint();
        //        animator.SetBool("IsWalking", false);
        //    }
        //}

        #endregion OLD INPUT - Selection
    }
}