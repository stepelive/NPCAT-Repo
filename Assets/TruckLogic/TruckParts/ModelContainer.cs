using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.TruckLogic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ModelContainer : MonoBehaviour
{

    [SerializeField] private List<TruckModel> _truckModelList;
    [SerializeField] private Button buttonPrefab;
    [SerializeField] private PartSelector _partSelector;
    [SerializeField] private List<TruckPart> AllParts;
    [SerializeField] private RectTransform _modelSelector;
    private void InitilizeMenu()
    {
        
        foreach (var model in _truckModelList)
        {
            
           // var btn = Instantiate(buttonPrefab, _modelSelector);
           /* btn.onClick.AddListener(delegate
            {
                _partSelector.gameObject.SetActive(true);
            });*/
        }
        

    }

    void Start()
    {
        
        InitilizeMenu();
    }
}
