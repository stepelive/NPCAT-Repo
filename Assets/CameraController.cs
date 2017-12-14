using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region SingletoneBody
    
    private static CameraController _instance;
    public static CameraController GetInstance()
    {
        if (_instance == null)
            _instance = new CameraController();
        return _instance;
    }
    private CameraController()
    {

    }
    #endregion
    public float TurnSpeed = 0.3f;
    public Transform ParentTransform;
    private float _prePosX;
    private bool _isRotating;
    void Start()
    {
        _instance = this;
    }

    void Update()
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

    public IEnumerator ChangeDistance(Vector3 newPos, float newDistance)
    {
        var move = (newPos - ParentTransform.position) / 20;
        var dis = (newDistance - Vector3.Distance(ParentTransform.position, newPos)) / 20;
        var pos = ParentTransform.position;
        for (int i = 0; i < 20; i++)
        {
            ParentTransform.position += move;
            yield return new WaitForSeconds(.01f);
        }
    }
}
