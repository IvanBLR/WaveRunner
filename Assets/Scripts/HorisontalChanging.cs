using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HorisontalChanging : MonoBehaviour
{
    [SerializeField]
    private GameObject _sphere;


    [SerializeField]
    private float _endPositionX;

    private Vector3 _startPosition;

    private float _timeForMovement = 3;
    private float _time;
    private bool _flag = true;

    private void Start()
    {
        _startPosition = _sphere.transform.position;
    }
    private void Update()
    {
        _time += Time.deltaTime;
        if (_flag)
        {
            var currentPosition = Mathf.Lerp(_startPosition.x, _endPositionX, _time / _timeForMovement);
            _sphere.transform.position = new Vector3(currentPosition, _startPosition.y, _startPosition.z);
        }
        else
        {
            var currentPosition = Mathf.Lerp(_endPositionX, _startPosition.x, _time / _timeForMovement);
            _sphere.transform.position = new Vector3(currentPosition, _startPosition.y, _startPosition.z);
        }
        if (_time >= _timeForMovement)
        {
            _time = 0;
            _flag = !_flag;
        }
    }
}
