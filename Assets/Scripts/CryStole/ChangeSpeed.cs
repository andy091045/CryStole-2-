using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    public float changespeed=0;
    public SpeedType speedType;
    private void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.CompareTag("Player"))
        {
            if (speedType == SpeedType.AddSpeed)
            {
                CarType2.Instance.speed = changespeed;
            }
            if (speedType == SpeedType.MinusSpeed)
            {
                CarType2.Instance.speed = changespeed;
            }
        }
    }

    public enum SpeedType
    {
        AddSpeed, MinusSpeed
    }
}
