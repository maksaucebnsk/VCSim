using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLoose : MonoBehaviour
{
    [SerializeField] Timer _timer;
    [SerializeField] DustChanger _dust;
    [SerializeField] FurnitureChanger _furniture;
    [SerializeField] GameObject _winWindow;
    [SerializeField] GameObject _looseWindow;
    [SerializeField] GameObject _player;
    void Update()
    {
        if (_timer._timerIsRunning && _dust._won && _furniture._won)
        {
            _winWindow.SetActive(true);
            _player.SetActive(false);
            _timer.StopTimer();
        }
        else if (!_timer._timerIsRunning && _player.activeInHierarchy)
        {
            _looseWindow.SetActive(true);
            _player.SetActive(false);
            _timer.StopTimer();
        }
    }
}
