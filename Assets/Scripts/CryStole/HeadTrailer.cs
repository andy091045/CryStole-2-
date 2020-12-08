using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTrailer : MonoBehaviour
{
    public GameObject targetPosition;   // 目標位置
    Vector3 currentVelocity = Vector3.zero;     // 當前速度，這個值由你每次呼叫這個函式時被修改
    float maxSpeed = 100f;    // 選擇允許你限制的最大速度
    float smoothTime = 0.01f;      // 達到目標大約花費的時間。 一個較小的值將更快達到目標。

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition.transform.position, ref currentVelocity, smoothTime, maxSpeed);
    }
    void OnTriggerEnter(Collider other)
    {
        //碰到障礙物扣血
        //  if (other.gameObject.CompareTag("BlockObject"))
        //     {
        //         HP.Instance.CountHP(3);               
        //     }
    }
}
