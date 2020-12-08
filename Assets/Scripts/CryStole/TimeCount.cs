using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimeCount : MonoBehaviour
{
    public GameObject HP_UI;
    int timerN = 5;
    // Start is called before the first frame update
    void Start()
    {
        CarType2.Instance.speed = 0.1f;
        InvokeRepeating("timer", 1, 1);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     HP_UI.GetComponent<TMP_Text>().text = timer + " ";
    //     timer = timer - Time.deltaTime;
    //     if (timer <= 0f)
    //     {
    //         CarType2.Instance.speed = 10;
    //         Destroy(this);
    //     }


    // }
    public void timer()
    {

        timerN -= 1;

        HP_UI.GetComponent<TMP_Text>().text = timerN + " ";

        if (timerN == 0)
        {
            CarType2.Instance.speed = 10;
            CancelInvoke("timer");
            Destroy(HP_UI.gameObject);
        }

    }
}
