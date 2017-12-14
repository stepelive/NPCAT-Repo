using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PresentationController : MonoBehaviour
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
}
