using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

   

    private readonly Vector2 _centerScreen = new Vector2(Screen.width / 2, Screen.height / 2);
    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
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
            //_textPanel.position = new Vector3(Screen.width-_textPanel.sizeDelta.x, _centerScreen.y);
            Debug.DrawLine(_pointer.position, _textPanel.position);
	        /*_lineRectTransforms.LookAt(_textPanel);
	        _lineRectTransforms.localEulerAngles += RotationOffset;*/
	    }
	}

    public Vector3 RotationOffset;
    public void UpdateState()
    {
        
    }

}
