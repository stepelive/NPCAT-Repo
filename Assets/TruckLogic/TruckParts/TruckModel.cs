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


}
