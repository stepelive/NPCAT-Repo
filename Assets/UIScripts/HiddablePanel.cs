using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddablePanel : MonoBehaviour
{

    [SerializeField] private Vector2 _hiddenPos;
    [SerializeField] private Vector2 _showedPos;
    [SerializeField] private bool hideToLeft;
    private RectTransform _selfRectTransform;
    private bool _state=true;

    public void Show()
    {
        
        StartCoroutine(StartMove(_showedPos,true));
    }

    IEnumerator StartMove(Vector2 newPos, bool newState)
    {
        var move = (newPos- _selfRectTransform.anchoredPosition )/20;
        var pos = _selfRectTransform.anchoredPosition;
        for (int i = 0; i < 20; i++)
        {
            _selfRectTransform.anchoredPosition += move;
            yield return new WaitForSeconds(.01f);
        }
        _state = newState;
    }
    public void Hide()
    {
        if (_state)
        {
            var napravlenie = hideToLeft ? 1 : -1;
            _hiddenPos =
                new Vector2((-_selfRectTransform.sizeDelta.x + 25 * UIBuilder.GetInstance().PanelScale) * napravlenie,
                    _hiddenPos.y);
            StartCoroutine(StartMove(_hiddenPos, false));
        }
    }

    

    public void ChangeState()
    {
        if(_state)
            Hide();
        else 
            Show();
    }

    public void Start()
    {
        _selfRectTransform = GetComponent<RectTransform>();
    }

}

