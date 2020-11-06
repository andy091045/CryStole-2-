using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCount : MonoBehaviour
{
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if(timer>=1f){
             LeftWeapon.Instance.ChangePosition();
             RightWeapon.Instance.ChangePosition();
            timer=0f;           
        }
          
        
    }
}
