//
// Pickup.cs: 
//   Abstract class for all pickups
//
// Author:
//   Michael Libman
//

using UnityEngine;

public abstract class Pickup : MonoBehaviour 
{
    #region Public Methods
    public abstract void PickupItem();
    public abstract void RegisterItem();
    public abstract void UnregisterItem();
    #endregion
}
