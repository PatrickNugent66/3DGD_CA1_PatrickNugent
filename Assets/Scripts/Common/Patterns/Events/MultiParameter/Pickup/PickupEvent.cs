using System;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Customer multi-parameter event passing
/// </summary>
/// <see cref="https://www.youtube.com/watch?v=iXNwWpG7EhM"/>
namespace GD.Events
{
    [Serializable]
    public struct PickupData
    {
        public string name;
        public GameObject pickup;

        public override string ToString()
        {
            return $"{name}";
        }
    }

    [CreateAssetMenu(fileName = "PickupEvent", menuName = "Scriptable Objects/Events/Pickup")]
    public class PickupEvent : BaseGameEvent<PickupData>
    {
        //public override void Raise(PickupData parameters)
        //{
        //    base.Raise(parameters);
        //}
    }

    [Serializable]
    public class UnityPickupEvent : UnityEvent<PickupData>
    {
    }
}