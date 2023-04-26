using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateChanging : MonoBehaviour
{
    [SerializeField]
    private GameObject _romb;

    private void Update()
    {
        _romb.transform.Rotate(Vector3.right, 25 * Time.deltaTime);
    }
}
