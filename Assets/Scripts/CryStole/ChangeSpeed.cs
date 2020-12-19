using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    public SpeedType speedType;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("碰到了");
        if (other.gameObject.CompareTag("Player"))
        {
            if (speedType == SpeedType.AddSpeed)
            {
                CarType2.Instance.speed = 11.45f;
            }
            if (speedType == SpeedType.MinusSpeed)
            {
                CarType2.Instance.speed = 10;
            }
        }
    }

    public enum SpeedType
    {
        AddSpeed, MinusSpeed
    }
}
