using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class NewFade : MonoBehaviour {

public float _fadeDuration = 10f;

private void Start()
{
    // FadeFromWhite();
}

public void FadeIn()
{
    //set start color
    SteamVR_Fade.View(Color.black, 0f);
    //set and start fade to
    SteamVR_Fade.View(Color.clear, _fadeDuration);
    Debug.Log("淡入");
}
public void FadeOut(){
    //set start color
    SteamVR_Fade.View(Color.clear, 0f);
    //set and start fade to
    SteamVR_Fade.View(Color.black, _fadeDuration);
    Debug.Log("淡出");
}
}
