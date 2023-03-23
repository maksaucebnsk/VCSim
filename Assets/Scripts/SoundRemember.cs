using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundRemember : MonoBehaviour
{
    private float _volume;
    private Scrollbar _scrollbar;

    private void Start()
    {
        _scrollbar = GetComponent<Scrollbar>();
    }
    void Update()
    {
        _volume = _scrollbar.value;
        PlayerPrefs.SetFloat("SoundLoud",_volume);
    }
}
