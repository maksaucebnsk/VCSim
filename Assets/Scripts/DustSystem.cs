using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustSystem : MonoBehaviour
{
    [SerializeField] Resources _resources;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Dust")
        {
            Destroy(other.gameObject);
            _resources.DestroyedDust();
        }
    }
}
