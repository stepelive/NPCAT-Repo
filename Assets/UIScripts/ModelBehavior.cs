using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelBehavior : MonoBehaviour {

    #region SingletoneBody
    public static ModelBehavior GetInstance()
    {
        if (_instance == null)
        {
            _instance = new ModelBehavior();
        }
        return _instance;
    }
    private static ModelBehavior _instance;
    private ModelBehavior()
    {
        

    }
#endregion

    [SerializeField] private Toggle togglePrefab;
    [SerializeField] private RectTransform toggleParent;
    public void ShowModels(List<TruckModel> models)
    {
        Debug.Log(models.Count);
        ResetAllElements();
        foreach (var model in models)
        {
            var toggle = Instantiate(togglePrefab, toggleParent);
            toggle.group = toggleParent.GetComponent<ToggleGroup>();
            toggle.GetComponentInChildren<Text>().text = model.ModelName;
            toggle.onValueChanged.AddListener(delegate
                {
                    TruckController.GetInstance().ActiveTruck.ChangeModel(model, toggle.isOn);
                });
        }
    }
    private void ResetAllElements()
    {
        var childrens = toggleParent.GetComponentsInChildren<Toggle>();
        foreach (var children in childrens)
        {
            Debug.Log(children);
            GameObject.Destroy(children.gameObject);
        }

    }
    public void Start()
    {
        _instance = this;
    }

}
