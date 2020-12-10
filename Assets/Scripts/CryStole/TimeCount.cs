using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class TimeCount : MonoBehaviour
{
    public Image fadeImage;
    public GameObject HP_UI;
    int timerN = 5;
    // Start is called before the first frame update
    void Start()
    {
        CarType2.Instance.speed = 0.1f;
        StartCoroutine(Change());
    }
    IEnumerator Change()
    {
        while (fadeImage.color.a > 0)
        {
            //一開始是1
            float myAlpha = fadeImage.color.a - 0.01f;
            //R					//G					//B			  //Alpha
            fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, myAlpha);

            yield return new WaitForSeconds(0.01f);

        }
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
