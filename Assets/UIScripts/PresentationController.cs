using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PresentationController : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Transform _targetTruck;

    [SerializeField]
    private RectTransform _textPanel;

    [SerializeField]
    private RectTransform _lineRectTransforms;

    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private RectTransform _pointer;

    [SerializeField] private List<GameObject> _floatPanels;

    public void OnPointerClick(PointerEventData eventData)
    {
        DisableAllFloatPanels();
    }
    public void DisableAllFloatPanels()
    {
        foreach (var panel in _floatPanels)
        {
            panel.GetComponent<HiddablePanel>().Hide();
        }
    }
   
	
	void Update () {
	    if (_targetTruck != null)
	    {
	        var position = _camera.WorldToViewportPoint(_targetTruck.position);
	        Vector2 screenPosition = new Vector2
	        (
	            position.x * Screen.width,
	            position.y * Screen.height
            );
	        _pointer.position = screenPosition;
            Debug.DrawLine(_pointer.position, _textPanel.position);

	    }
	}

    public Vector3 RotationOffset;
    public void UpdateState()
    {
        
    }

}
