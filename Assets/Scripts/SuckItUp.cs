using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuckItUp : MonoBehaviour
{
    void OnCollisionStay(Collision other)
    {
        if (Input.GetKey(KeyCode.Space) && other.gameObject.TryGetComponent<Resizable>(out Resizable _resizable))
        {
            _resizable._isResizing = true;
        }
    }
}
