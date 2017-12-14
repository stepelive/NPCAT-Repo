using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.TruckLogic;
using UnityEngine;

public class TruckController : MonoBehaviour
{
    #region singletone

    public static TruckController GetInstance()
    {
        if (_instance==null)
            _instance=new TruckController();
        return _instance;
    }

    private static TruckController _instance;

    private TruckController()
    {
        
    }
    
    #endregion

    public List<Truck> Trucks;
    public Truck ActiveByDefault;
    public Truck ActiveTruck;
    void Start()
    {
        _instance = this;

        if (ActiveByDefault != null)
            if (Trucks.IndexOf(ActiveByDefault) != -1)
            {
                ActiveTruck = ActiveByDefault;
                ActiveByDefault.ChangeTruck();
            }
    }

    public void CheckDetail(TruckPart part,bool state)
    {
        switch (part.Type)
        {
            case PartType.Engine: ActiveTruck.CheckEngine(part, state);
                break;
            case PartType.Transmission: ActiveTruck.CheckTransmission(part, state);
                break;
            case PartType.Suspension: ActiveTruck.CheckSuspension(part, state);
                break;
            case PartType.Cabin: ActiveTruck.CheckCabine(part, state);
                break;
            case PartType.FuelTank:ActiveTruck.CheckFuelTank(part, state);
                break;
            case PartType.NeitralTank:ActiveTruck.CheckNeitralTank(part, state);
                break;
            case PartType.SleepArea:ActiveTruck.CheckSleepArea(part, state);
                break;
            case PartType.SpareWheel:ActiveTruck.CheckSpareWheel(part, state);
                break;
            case PartType.WheelBase:ActiveTruck.CheckWheelBase(part, state);
                break;
            case PartType.Dopog: ActiveTruck.CheckDopog(part, state);
                break;
            case PartType.InfoSystem: ActiveTruck.CheckInfoSystem(part, state);
                break;
        }
        ModelBehavior.GetInstance().ShowModels(ActiveTruck.GetAvailableModels());
    }

}
