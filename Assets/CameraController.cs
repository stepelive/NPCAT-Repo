using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float TurnSpeed = 0.3f; 
    public Transform ParentTransform;
    private float _prePosX;    
    private bool _isRotating; 
	void Update ()
	{
	    
	    if (_isRotating)
	    {
	        float Delta = Input.mousePosition.x - _prePosX;
            ParentTransform.RotateAround(ParentTransform.position, Vector3.up, Delta * TurnSpeed);
            _prePosX = Input.mousePosition.x;
        }
	    if (Input.GetMouseButton(0) && !_isRotating)
	    {
	        _isRotating = true;
	        _prePosX = Input.mousePosition.x;
	    }
	    else
	    {
	        _isRotating = false;

	    }
    }
    /*
    public Coroutine ChangeDistance()
    {

        
    }*/
}
