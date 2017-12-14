using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIBuilder : MonoBehaviour
{

    #region SingletoneBody
    public static UIBuilder GetInstance()
    {
        if (_instance==null)
        {
            _instance =new UIBuilder();
        }
        return _instance;
    }
    private static UIBuilder _instance;
    private UIBuilder()
    {
        
    }
    #endregion

    [SerializeField] private FilterButton _buttonPrefab;
    [SerializeField] private FilterButton _togglePrefab;
    [SerializeField] private PartSelector _partSelector;
    [SerializeField] private RectTransform _filterPanel;

    [SerializeField] private List<RectTransform> _scaledOjbects;
    [SerializeField] private List<GameObject> _scaledPadding;

    [SerializeField] private Sprite _engineSprite;
    [SerializeField] private Sprite _wheelBaseSprite;
    [SerializeField] private Sprite _transmissionSprite;
    [SerializeField] private Sprite _suspensionSprite;
    [SerializeField] private Sprite _sleepAreaSprite;
    [SerializeField] private Sprite _spareWheelSprite;
    [SerializeField] private Sprite _cabineSprite;
    [SerializeField] private Sprite _fuelTankSprite;
    [SerializeField] private Sprite _neitralTankSprite;
    [SerializeField] private Sprite _dopogSprite;
    [SerializeField] private Sprite _informationSystemSprite;
    
    public float PanelScale;
    public void BuildButton(List<TruckPart> engineList)
    {
        var btn = Instantiate(_buttonPrefab, _filterPanel);
        btn.GetComponent<FilterButton>().Image.sprite = IdentifySprite(engineList.FirstOrDefault());
        btn.GetComponentInChildren<Button>().onClick.AddListener(delegate {  _partSelector.Build(engineList,btn.GetComponentInChildren<Button>()); });
    }


    void Awake()
    {

        if (Screen.width > 1024)
        {
            float t = 1024;
            PanelScale =Screen.width /t ;
            Debug.Log(PanelScale);
            Debug.Log(Screen.width);
        }
        else PanelScale = 1;
        
        _instance = this;
    }

    void Start()
    {
        /*foreach (var ScaleObj in _scaledOjbects)
        {
            var currentScale = ScaleObj.sizeDelta;
            ScaleObj.sizeDelta = currentScale * PanelScale;
            ScaleObj.anchoredPosition = ScaleObj.anchoredPosition * PanelScale;
        }
        foreach (var scaledObj in _scaledPadding)
        {
            var group = scaledObj.GetComponent<HorizontalOrVerticalLayoutGroup>();
            if (group != null)
            {
                group.padding.left *= (int)PanelScale;
                group.padding.right *= (int)PanelScale;
                group.padding.bottom *= (int)PanelScale;
                group.padding.top *= (int)PanelScale;
            }

        }*/

       Debug.Log(  _filterPanel.GetComponent<HorizontalLayoutGroup>().padding.right= (Screen.width/100)*30);


    }
    public Sprite IdentifySprite(TruckPart part)
    {
        switch (part.Type)
        {
            case PartType.Engine: return _engineSprite;
            case PartType.Transmission:return _transmissionSprite;
            case PartType.Suspension:return _suspensionSprite;
            case PartType.Cabin:return _cabineSprite;
            case PartType.FuelTank:return _fuelTankSprite;
            case PartType.NeitralTank:return _neitralTankSprite;
            case PartType.SleepArea:return _sleepAreaSprite;
            case PartType.SpareWheel:return _spareWheelSprite;
            case PartType.WheelBase:return _wheelBaseSprite;
            case PartType.Dopog: return _dopogSprite;
            case PartType.InfoSystem: return _informationSystemSprite;
               default: return null;
        }
    }

    

}
