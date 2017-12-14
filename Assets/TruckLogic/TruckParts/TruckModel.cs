using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TruckModel : MonoBehaviour
{
    [SerializeField] public string ModelName;
    [SerializeField] public TruckPart Engine;
    [SerializeField] public TruckPart Transmission;
    [SerializeField] public TruckPart Cabin;
    [SerializeField] public TruckPart Suspension;
    [SerializeField] public TruckPart SleepArea;
    [SerializeField] public TruckPart WheelBase;
    [SerializeField] public TruckPart NeitralTank;
    [SerializeField] public TruckPart FuelTank;
    [SerializeField] public TruckPart SpareWheel;
    [SerializeField] public TruckPart Dopog;
    [SerializeField] public TruckPart InfoSystem;

    public float Price;

    public List<TruckPart> GetAllDetails()
    {
        List<TruckPart> details=new List<TruckPart>();

        details.Add(Engine);
        details.Add(Transmission);
        details.Add(Cabin);
        details.Add(Suspension);
        details.Add(SleepArea);
        details.Add(WheelBase);
        details.Add(NeitralTank);
        details.Add(FuelTank);
        details.Add(InfoSystem);
        details.Add(SpareWheel);
        details.Add(Dopog);
        return details;
    }
}
