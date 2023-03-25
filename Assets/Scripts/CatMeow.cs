using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMeow : MonoBehaviour
{
    [SerializeField] Resizable _resizable;
    private bool _once;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _once = true;
    }


    void Update()
    {
        if (_resizable._isResizing && _once)
        {
            _once = false;
            _audioSource.PlayOneShot(_audioSource.clip);
        }
    }
}
