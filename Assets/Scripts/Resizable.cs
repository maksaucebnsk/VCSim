using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizable : MonoBehaviour
{
    [SerializeField] Resources _resources;
    private Transform _transform;
    public bool _isResizing;

    private void Start()
    {
        _transform = gameObject.transform;
    }
    void Update()
    {
        if (_isResizing && _transform.localScale.y > Vector3.zero.y)
        {
            _transform.localScale = Vector3.Lerp(Vector3.zero, _transform.localScale -new Vector3(0.01f, 0.01f, 0.01f), Time.fixedDeltaTime * 100f);
        }
        else if (_transform.localScale.y <= Vector3.zero.y)
        {
            Destroy(gameObject);
            _resources.DestroyedFurniture();
        }
    }
}
