using UnityEngine;
using UnityEngine.UIElements;

public class VerticalChanging : MonoBehaviour
{
    [SerializeField]
    private GameObject _cylindr;

    private Vector3 _startPosition;

    private float _endPositionY;

    private float _allTime = 2f;
    private float _time;
    private bool _flag = true;


    private void Awake()
    {
        _startPosition = _cylindr.transform.position;
        _endPositionY = _startPosition.y + 5;
    }
    private void Update()
    {
        _time += Time.deltaTime;

        if (_flag)
        {
            var currentPositionY = Mathf.Lerp(_startPosition.y, _endPositionY, _time / _allTime);
            _cylindr.transform.position = new Vector3(_startPosition.x, currentPositionY, _startPosition.z);
        }
        else
        {
            var currentPositionY = Mathf.Lerp(_endPositionY, _startPosition.y, _time / _allTime);
            _cylindr.transform.position = new Vector3(_startPosition.x, currentPositionY, _startPosition.z);

        }
        if (_time >= _allTime)
        {
            _flag = !_flag;
            _time = 0f;
        }
    }



}
