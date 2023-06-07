using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cooldown
{
    public float total;
    public float current;

    public bool isReady => current >= total;

    public float normalizedTime => current / total;

    public void Reset()
    {
        current = 1;
    }
}
