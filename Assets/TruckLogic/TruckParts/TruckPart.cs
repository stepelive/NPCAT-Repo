using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckPart : MonoBehaviour
{
    [SerializeField] private string _name;

    [SerializeField]
    private PartType _type;

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public PartType Type
    {
        get
        {
            return _type;
        }
    }
}

public enum PartType
{
    Engine,
    Transmission,
    Cabin,
    Suspension,
    SleepArea,
    WheelBase,
    NeitralTank,
    FuelTank,
    SpareWheel
}

