using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class FurnitureChanger : MonoBehaviour
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
        _textMeshPro.text = $"{_resources._destroyedFurniture.ToString()}/{_ammount.ToString()}";
        if (_resources._destroyedFurniture == _ammount)
        {
            _textMeshPro.color = Color.green;
            _won = true;
        }
    }
}
