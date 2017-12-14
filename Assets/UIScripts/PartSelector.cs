using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartSelector : MonoBehaviour
{
    public List<GameObject> activeElements;
    public List<GameObject> disabledElements;

    [SerializeField] private Button _buttonPrefab;
    [SerializeField] private Toggle _togglePrefab;

    [SerializeField] private RectTransform toggleParentTransform;
    [SerializeField] private RectTransform buttonParentTransform;

    private static Button _activeSelector;

    void Start()
    {
        activeElements = new List<GameObject>();
    }
    /// <summary>
    /// Тут есть баг, пока не исправлен
    /// </summary>
    /// <param name="_truckParts"></param>
    public void Build(List<TruckPart> _truckParts,Button sender)
    {
        if (_activeSelector == sender)
        {
            GetComponent<HiddablePanel>().Hide();
            _activeSelector = null;

        }
        else
        {
            _activeSelector = sender;
            GetComponent<HiddablePanel>().Show();
            ResetAllElements();

            activeElements = new List<GameObject>();

            foreach (var part in _truckParts)
            {
                var newbtn = InstantiateNewToggle();
                newbtn.GetComponentInChildren<Text>().text = part.Name;
                newbtn.isOn = part.gameObject.activeSelf;
                newbtn.onValueChanged.AddListener(delegate
                {
                    TruckController.GetInstance().CheckDetail(part, newbtn.isOn);
                });
                if (disabledElements.Contains(newbtn.gameObject))
                    disabledElements.Remove(newbtn.gameObject);
                activeElements.Add(newbtn.gameObject);
            }
        }


    }
    private Toggle InstantiateNewToggle()
    {
        var t = Instantiate(_togglePrefab, toggleParentTransform);
        t.group = toggleParentTransform.GetComponent<ToggleGroup>();
        return t;
    }
  
    private void ResetAllElements()
    {
        var childrens = toggleParentTransform.GetComponentsInChildren<Toggle>();
        foreach (var children in childrens)
        {
            GameObject.Destroy(children.gameObject);
        }

    }
}
