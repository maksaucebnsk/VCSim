using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFov : MonoBehaviour
{
    private Camera _camera;

    void Update()
    {
        var frustumHeight = 2.0f * 10 * Mathf.Tan(_camera.fieldOfView * 0.5f * Mathf.Deg2Rad);
    }
}
