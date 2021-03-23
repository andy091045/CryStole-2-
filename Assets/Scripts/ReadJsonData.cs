using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using System.IO;

public class ReadJsonData : MonoBehaviour
{
    // int n = 0;
    public UnityEvent apple = null;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     n = 1;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if(n == 1){
    //        apple.Invoke();
    //        n++;
    //     }
     
    // }

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        TestJson.Instance.ReadJson();
    }
}