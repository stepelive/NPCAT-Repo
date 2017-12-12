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
    private Truck _activeTruck;
    void Start()
    {
        _instance = this;

        if (ActiveByDefault != null)
            if (Trucks.IndexOf(ActiveByDefault) != -1)
            {
                _activeTruck = ActiveByDefault;
                ActiveByDefault.ChangeTruck();
            }
    }

    public void CheckDetail(TruckPart part)
    {
        switch (part.Type)
        {
            case PartType.Engine: _activeTruck.CheckEngine(part);
                break;
            case PartType.Transmission: _activeTruck.CheckTransmission(part);
                break;
            case PartType.Suspension: _activeTruck.CheckSuspension(part);
                break;
            case PartType.Cabin: _activeTruck.CheckCabine(part);
                break;
            case PartType.FuelTank:_activeTruck.CheckFuelTank(part);
                break;
        }
    }

}
