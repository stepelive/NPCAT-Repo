using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.TruckLogic
{
    public class Truck:MonoBehaviour
    {
        public Sprite TruckSprite;
        public List<TruckModel> TruckModels;
        public UIBuilder UiBuilder;

        private TruckPart _engine;

        private TruckPart _transmission;

        private TruckPart _suspension;

        private TruckPart _cabine;

        private TruckPart _fuelTank;

        private TruckPart _sleepArea;


        public void  CheckEngine(TruckPart engine)
        {
           CheckDetail(engine, _engine);
            _engine = engine;
        }
        public void CheckTransmission(TruckPart transmission)
        {
            CheckDetail(transmission,_transmission);
            _transmission = transmission;
        }

        public void CheckSuspension(TruckPart suspension)
        {
            CheckDetail(suspension, _suspension);
            _suspension = suspension;
        }

        public void CheckCabine(TruckPart cabine)
        {
            CheckDetail(cabine, _cabine);
            _cabine = cabine;
        }

        public void CheckFuelTank(TruckPart FuelTank)
        {
            CheckDetail(FuelTank,_fuelTank);
            _fuelTank = FuelTank;
        }
        public void ChangeTruck()
        {
            var Engines = TruckModels.Select(t => t.Engine).Distinct().ToList();
            UiBuilder.BuildButton(Engines);
            var Suspensions = TruckModels.Select(t => t.Suspension).Distinct().ToList();
            UiBuilder.BuildButton(Suspensions);
            var Transmissions = TruckModels.Select(t => t.Transmission).Distinct().ToList();
            UiBuilder.BuildButton(Transmissions);
            var Cabins = TruckModels.Select(t => t.Cabin).Distinct().ToList();
            UiBuilder.BuildButton(Cabins);
            var FuelTanks = TruckModels.Select(t => t.FuelTank).Distinct().ToList();
            UiBuilder.BuildButton(FuelTanks);

            /*
             var SleepAreas = TruckModels.Select(t => t.SleepArea).ToList();
             UiBuilder.BuildButton(SleepAreas);
              
              var NeitralTanks = TruckModels.Select(t => t.NeitralTank).ToList();
              UiBuilder.BuildButton(NeitralTanks);
              var SleepAreas = TruckModels.Select(t => t.SleepArea).ToList();
              UiBuilder.BuildButton(SleepAreas);
              var SpareWheels = TruckModels.Select(t => t.SpareWheel).ToList();
              UiBuilder.BuildButton(SpareWheels);
              var WheelBases = TruckModels.Select(t => t.WheelBase).ToList();
              UiBuilder.BuildButton(WheelBases);
              */
        }

        private void CheckDetail(TruckPart newDetail, TruckPart oldDetail)
        {
            if (oldDetail != null && oldDetail != newDetail)
            {
                oldDetail.gameObject.SetActive(false);
            }
            newDetail.gameObject.SetActive(true);
        }
    }
}
