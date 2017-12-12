using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class UIBuilder : MonoBehaviour {

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

    [SerializeField] private Sprite _engineSprite;
    [SerializeField] private FilterButton _buttonPrefab;
    [SerializeField] private PartSelector _partSelector;
    [SerializeField] private RectTransform _filterPanel;
    public void BuildButton(List<TruckPart> engineList)
    {
        var btn = Instantiate(_buttonPrefab, _filterPanel);
        btn.GetComponent<Button>().onClick.AddListener(delegate {  _partSelector.Build(engineList); });
        
    }

   

    void Awake()
    {
        _instance = this;
    }

}
