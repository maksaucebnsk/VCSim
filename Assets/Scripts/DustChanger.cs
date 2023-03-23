using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class DustChanger : MonoBehaviour
{
    [SerializeField] Resources _resources;
    private TextMeshProUGUI _textMeshPro;
    public bool _won;
    public int _ammount;

    private void Start()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        _textMeshPro.text = $"{_resources._destroyedDust.ToString()}/{_ammount.ToString()}";
        if (_resources._destroyedDust == _ammount)
        {
            _textMeshPro.color = Color.green;
            _won = true;
        }
    }
}
