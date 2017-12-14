using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.TruckLogic
{
    public class Truck : MonoBehaviour
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

        private TruckPart _spareWheel;

        private TruckPart _neitralTank;

        private TruckPart _wheelbase;

        private TruckPart _dopog;

        private TruckPart _infoSystem;

        private List<TruckPart> _currentComplectaion;
        public void CheckEngine(TruckPart engine, bool state)
        {
            if (state)
            {
                if (_engine != null)
                {
                    _currentComplectaion.Remove(_engine);
                    _engine.gameObject.SetActive(false);
                }
                _engine = engine;
                engine.gameObject.SetActive(true);
                _currentComplectaion.Add(_engine);
            }
            else if (_engine != null)
            {
                _engine.gameObject.SetActive(false);
                _currentComplectaion.Remove(_engine);
            }
        }

        public void CheckTransmission(TruckPart transmission, bool state)
        {

            if (state)
            {
                if (_transmission != null)
                {
                    _transmission.gameObject.SetActive(false);
                    _currentComplectaion.Remove(_transmission);
                }
                _transmission = transmission;
                transmission.gameObject.SetActive(true);
                _currentComplectaion.Add(_transmission);
            }
            else if (_transmission != null)
            {
                _transmission.gameObject.SetActive(false);
                _currentComplectaion.Remove(_transmission);
            }
        }
        public void CheckSuspension(TruckPart suspension, bool state)
        {
            if (state)
            {
                if (_suspension != null)
                {
                    _suspension.gameObject.SetActive(false);
                    _currentComplectaion.Remove(_suspension);
                }
                _suspension = suspension;
                suspension.gameObject.SetActive(true);
                _currentComplectaion.Add(_suspension);
            }
            else if (_suspension != null)
            {

                _suspension.gameObject.SetActive(false);
                _currentComplectaion.Remove(_suspension);
            }
        }

        public void CheckCabine(TruckPart cabine, bool state)
        {
            if (state)
            {
                if (_cabine != null)
                {
                    _cabine.gameObject.SetActive(false);
                    _currentComplectaion.Remove(_cabine);
                }
                _cabine = cabine;
                cabine.gameObject.SetActive(true);
                _currentComplectaion.Add(_cabine);
            }
            else if (_cabine != null)
            {

                _cabine.gameObject.SetActive(false);
                _currentComplectaion.Remove(_cabine);
            }
        }

        public void CheckFuelTank(TruckPart FuelTank, bool state)
        {
            if (state)
            {
                if (_fuelTank != null)
                {
                    _fuelTank.gameObject.SetActive(false);
                    _currentComplectaion.Remove(_fuelTank);
                }
                _fuelTank = FuelTank;
                FuelTank.gameObject.SetActive(true);
                _currentComplectaion.Add(_fuelTank);
            }
            else if (_fuelTank != null)
            {
                _fuelTank.gameObject.SetActive(false);
                _currentComplectaion.Remove(_fuelTank);
            }
        }
        public void CheckNeitralTank(TruckPart part, bool state)
        {
            if (state)
            {
                if (_neitralTank != null)
                {
                    _neitralTank.gameObject.SetActive(false);
                    _currentComplectaion.Remove(_neitralTank);
                }
                _neitralTank = part;
                part.gameObject.SetActive(true);
                _currentComplectaion.Add(_neitralTank);
            }
            else if (_neitralTank != null)
            {
                _neitralTank.gameObject.SetActive(false);
                _currentComplectaion.Remove(_neitralTank);
            }
        }

        public void CheckSleepArea(TruckPart part, bool state)
        {
            if (state)
            {
                if (_sleepArea != null)
                {
                    _sleepArea.gameObject.SetActive(false);
                    _currentComplectaion.Remove(_neitralTank);
                }
                _sleepArea = part;
                part.gameObject.SetActive(true);
                _currentComplectaion.Add(_neitralTank);
            }
            else if (_sleepArea != null)
            {
                _sleepArea.gameObject.SetActive(false);
                _currentComplectaion.Remove(_neitralTank);
            }
        }

        public void CheckSpareWheel(TruckPart part, bool state)
        {
            if (state)
            {
                if (_spareWheel != null)
                {
                    _spareWheel.gameObject.SetActive(false);
                    _currentComplectaion.Remove(_spareWheel);
                }
                _spareWheel = part;
                part.gameObject.SetActive(true);
                _currentComplectaion.Add(_spareWheel);
            }
            else if (_spareWheel != null)
            {
                _spareWheel.gameObject.SetActive(false);
                _currentComplectaion.Remove(_spareWheel);
            }
        }

        public void CheckWheelBase(TruckPart part, bool state)
        {
            if (state)
            {
                if (_wheelbase != null)
                {
                    _wheelbase.gameObject.SetActive(false);
                    _currentComplectaion.Remove(_wheelbase);
                }
                _wheelbase = part;
                part.gameObject.SetActive(true);
                _currentComplectaion.Add(_wheelbase);
            }
            else if (_wheelbase != null)
            {
                _wheelbase.gameObject.SetActive(false);
                _currentComplectaion.Remove(_wheelbase);
            }
        }

        public void CheckDopog(TruckPart engine, bool state)
        {
            if (state)
            {
                if (_dopog != null)
                {
                    _currentComplectaion.Remove(_dopog);
                    _dopog.gameObject.SetActive(false);
                }
                _dopog = engine;
                engine.gameObject.SetActive(true);
                _currentComplectaion.Add(_dopog);
            }
            else if (_engine != null)
            {
                _dopog.gameObject.SetActive(false);
                _currentComplectaion.Remove(_dopog);
            }
        }
        public void CheckInfoSystem(TruckPart engine, bool state)
        {
            if (state)
            {
                if (_infoSystem != null)
                {
                    _currentComplectaion.Remove(_infoSystem);
                    _infoSystem.gameObject.SetActive(false);
                }
                _infoSystem = engine;
                engine.gameObject.SetActive(true);
                _currentComplectaion.Add(_infoSystem);
            }
            else if (_engine != null)
            {
                _infoSystem.gameObject.SetActive(false);
                _currentComplectaion.Remove(_infoSystem);
            }
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

            var NeitralTanks = TruckModels.Select(t => t.NeitralTank).Distinct().ToList();
            UiBuilder.BuildButton(NeitralTanks);

            var SleepAreas = TruckModels.Select(t => t.SleepArea).Distinct().ToList();
            UiBuilder.BuildButton(SleepAreas);

            var SpareWheels = TruckModels.Select(t => t.SpareWheel).Distinct().ToList();
            UiBuilder.BuildButton(SpareWheels);

            var WheelBases = TruckModels.Select(t => t.WheelBase).Distinct().ToList();
            UiBuilder.BuildButton(WheelBases);

            var Dopog = TruckModels.Select(t => t.Dopog).Distinct().Where(d => d != null).ToList();
            UiBuilder.BuildButton(Dopog);
            var InfoSystem = TruckModels.Select(t => t.InfoSystem).Distinct().ToList();
            UiBuilder.BuildButton(InfoSystem);
        }


        public List<TruckModel> GetAvailableModels()
        {
            var models = new List<TruckModel>(TruckModels);
            foreach (var model in TruckModels)
            {
                var alpartsinModel = model.GetAllDetails();
                foreach (var cur in _currentComplectaion)
                {
                    if (!alpartsinModel.Contains(cur))
                        models.Remove(model);
                }

            }
            return models.Distinct().ToList();
        }

        public void Start()
        {
            _currentComplectaion = new List<TruckPart>();
        }

        public void ChangeModel(TruckModel model, bool IsActive)
        {

            CheckSuspension(model.Suspension, IsActive);
            CheckCabine(model.Cabin, IsActive);
            CheckEngine(model.Engine, IsActive);
            CheckFuelTank(model.FuelTank, IsActive);
            CheckNeitralTank(model.NeitralTank, IsActive);
            CheckSpareWheel(model.SpareWheel, IsActive);
            CheckTransmission(model.Transmission, IsActive);
            CheckWheelBase(model.WheelBase,IsActive);  
            CheckDopog(model.Dopog,IsActive);
            CheckInfoSystem(model.InfoSystem,IsActive);
        }
    }
}
