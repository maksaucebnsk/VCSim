using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject _subject;
    private Vector3 _transformVector;

    void FixedUpdate()
    {
        _transformVector = _subject.GetComponent<Transform>().position;
        if (_transformVector.x< -7f)
        {
            _transformVector.x = -7f;
        }
        else if (_transformVector.x > 10f)
        {
            _transformVector.x = 10f;
        }
        if (_transformVector.z < -8f)
        {
            _transformVector.z = -8f;
        }
        else if (_transformVector.z > 5f)
        {
            _transformVector.z = 5f;
        }
        transform.position = Vector3.Lerp(transform.position, _transformVector+Vector3.up*10, Time.fixedDeltaTime*2f);
    }
}
