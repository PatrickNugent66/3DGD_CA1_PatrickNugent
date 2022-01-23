using GD.Events;
using UnityEngine;

public class PlayerPickupBehaviour : MonoBehaviour
{
    [SerializeField]
    private LayerMask pickupTargetLayer;

    [SerializeField]
    private PickupEvent pickupEvent;

    [SerializeField]
    private StringEvent stringEvent;

    private void CollectPickup(Collider other)
    {
        var pickup = other.gameObject.GetComponent<PickupBehaviour>();
        if (pickup != null)
        {
            ///stringEvent.Raise("Something amazing happened!!!");
            pickupEvent.Raise(pickup.PickupData);
            //Destroy(other.gameObject);
        }
    }
}