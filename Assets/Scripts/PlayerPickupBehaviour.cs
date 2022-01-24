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

    public void CollectPickup(GameObject collectedPickup)
    {
        var pickup = collectedPickup.GetComponent<PickupBehaviour>();
        if (pickup != null)
        {
            pickupEvent.Raise(pickup.PickupData);
            this.GetComponent<AudioSource>().Play();
        }
    }
}