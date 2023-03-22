using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject _subject;
    private Transform _subjectTransform;

    void FixedUpdate()
    {
        _subjectTransform = _subject.GetComponent<Transform>();
        transform.position = Vector3.Lerp(transform.position, _subjectTransform.position+Vector3.up*10, Time.fixedDeltaTime*2f);
    }
}
