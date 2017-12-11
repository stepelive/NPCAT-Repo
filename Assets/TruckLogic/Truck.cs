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

        public void ChangeTruck()
        {
            var Engines = TruckModels.Select(t => t.Engine).ToList();
            UiBuilder.BuildEngineButton(Engines);
        }
    }
}
