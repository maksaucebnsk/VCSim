using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    public int _destroyedDust;
    public int _destroyedFurniture;
    public void DestroyedDust()
    {
        _destroyedDust++;
    }
    public void DestroyedFurniture()
    {
        _destroyedFurniture++;
    }
}
