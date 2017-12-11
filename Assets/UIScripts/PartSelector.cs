using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartSelector : MonoBehaviour
{
    public List<GameObject> activeElements;
    public List<GameObject> disabledElements;

    [SerializeField] private Button _buttonPrefab;
    [SerializeField] private Button _togglePrefab;

    [SerializeField] private RectTransform toggleParentTransform;
    [SerializeField] private RectTransform buttonParentTransform;
    void Start()
    {
        activeElements = new List<GameObject>();
    }
    /// <summary>
    /// Тут есть баг, пока не исправлен
    /// </summary>
    /// <param name="_truckParts"></param>
    public void Build(List<TruckPart> _truckParts)
    {
        gameObject.SetActive(true);
        ResetAllElements();
        
        activeElements = new List<GameObject>();
        foreach (var part in _truckParts)
        {
            var newbtn = InstantiateNewButton();
            newbtn.GetComponentInChildren<Text>().text = part.Name;
            newbtn.onClick.AddListener(delegate {
                part.gameObject.SetActive(true); });
            if (disabledElements.Contains(newbtn.gameObject))
                disabledElements.Remove(newbtn.gameObject);
            activeElements.Add(newbtn.gameObject);
            Debug.Log("@");
        }

    }

    private Button InstantiateNewButton()
    {
        if (disabledElements.Count != 0)
        {
            disabledElements[0].SetActive(true);
            return disabledElements[0].GetComponent<Button>();
        }
        var t = Instantiate(_buttonPrefab, buttonParentTransform);
        return t;
    }

    private void ResetAllElements()
    {
        var childrens = buttonParentTransform.GetComponentsInChildren<Button>();
        foreach (var children in childrens)
        {
            children.gameObject.SetActive(false);
        }
        for(var i=0; i<activeElements.Count; i++)
        {
            activeElements[i].SetActive(false);
            disabledElements.Add(activeElements[i]);
        }
        
    }
}
