using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHurt : MonoBehaviour
{
    public static GetHurt Instance;
   public float fadeSpeed = 1.5f;
    public bool HurtStarting = false;
    private RawImage rawImage;
    void Awake()
    {
        Instance=this;
        rawImage = GetComponent<RawImage>();
    }

    void Start()
    {
        rawImage.enabled = false;
    }

    void Update()
    {
        if (HurtStarting)
            HurtAnimate();
    }

    private void FadeToClear()
    {
        rawImage.color = Color.Lerp(rawImage.color, Color.clear, fadeSpeed * Time.deltaTime);
    }
    void HurtAnimate()
    {   rawImage.enabled = true;
        FadeToClear();
        if (rawImage.color.a < 0.05f)
        {
            rawImage.color = Color.clear;
            rawImage.enabled = false;
            rawImage.color= new Color32(255, 0, 0, 150);
            HurtStarting = false;
        }
    }
}
