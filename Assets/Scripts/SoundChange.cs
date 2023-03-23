using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundChange : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        _audioSource.volume = PlayerPrefs.GetFloat("SoundLoud");

    }

}
