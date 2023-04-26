using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanging : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;

    [SerializeField]
    private Vector3 _maxScale;

    private Vector3 _startScale;
    private float _timeFroTransformation = 2;
    private float _time;

    private bool _flag;
    private void Start()
    {
        _startScale = _cube.transform.localScale;
    }
    private void Update()
    {
        _time += Time.deltaTime;
        if (_flag)
        {
            var currentScale = Vector3.Lerp(_startScale, _maxScale, _time / _timeFroTransformation);
            _cube.transform.localScale = currentScale;
        }
        else
        {
            var currentScale = Vector3.Lerp(_maxScale, _startScale, _time / _timeFroTransformation);
            _cube.transform.localScale = currentScale;
        }
        if (_time >= _timeFroTransformation)
        {
            _time = 0;
            _flag = !_flag;
        }
    }

}
