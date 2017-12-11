using System.Collections;
using System.Collections.Generic;
using Assets.TruckLogic;
using UnityEngine;

public class TruckController : MonoBehaviour
{
    public List<Truck> Trucks;
    public Truck ActiveByDefault;
    private Truck _activeTruck;
    // Use this for initialization
    void Start()
    {
        if (ActiveByDefault != null)
            if (Trucks.IndexOf(ActiveByDefault) != -1)
            {
                _activeTruck = ActiveByDefault;
                ActiveByDefault.ChangeTruck();
            }
    }

    // Update is called once per frame

}
