using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToLive : MonoBehaviour
{
    public Cooldown timeToLive;

    private void FixedUpdate()
    {
        timeToLive.current += Time.deltaTime;

        if (timeToLive.isReady)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
