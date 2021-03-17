using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.Extras;

public class PlayerUIButton : MonoBehaviour
{
    // private PointerEventArgs pointerEventArgs;
    // public SteamVR_LaserPointer SteamVrLaserPointer;
    public UnityEvent PlayerOnEnter = null;
    public UnityEvent PlayerOnClick = null;
    public UnityEvent PlayerOnUp = null;
    public UnityEvent IntroductionOnClick = null;
    public UnityEvent IntroductionOnEnter = null;
    public UnityEvent IntroductionOnUp = null;
    public Image m_Image = null;

    // void Start()
    // {
    //     mOnEnter.AddListener(OnButtonEnter);
    //     mOnClick.AddListener(OnButtonClick);
    //     mOnUp.AddListener(OnButtonUp);
    // }

    // void OnEnable()
    // {
    //     SteamVrLaserPointer.PointerClick += SteamVrLaserPointerClick;
    //     SteamVrLaserPointer.PointerIn += SteamVrLaserPointerIn;
    //     SteamVrLaserPointer.PointerOut += SteamVrLaserPointerOut;
    // }

    // void OnDestroy()
    // {
    //     SteamVrLaserPointer.PointerClick -= SteamVrLaserPointerClick;
    //     SteamVrLaserPointer.PointerIn -= SteamVrLaserPointerIn;
    //     SteamVrLaserPointer.PointerOut -= SteamVrLaserPointerOut;
    // }

    // private void SteamVrLaserPointerOut(object sender, PointerEventArgs e)
    // {
    //     if (e.target.gameObject == this.gameObject)
    //     {
    //         if (mOnUp != null) mOnUp.Invoke();
    //     }
    // }

    // private void SteamVrLaserPointerIn(object sender, PointerEventArgs e)
    // {
    //     if (e.target.gameObject == this.gameObject)
    //     {
    //         if (mOnEnter != null) mOnEnter.Invoke();
    //     }
    // }

    // private void SteamVrLaserPointerClick(object sender, PointerEventArgs e)
    // {
    //     if (e.target.gameObject == this.gameObject)
    //     {
    //         if (mOnClick != null) mOnClick.Invoke();
    //     }
    // }

    // public void OnButtonClick()
    // {
    //     Debug.Log("OnButtonClick");
    // }
    // public void OnButtonEnter()
    // {
    //     Debug.Log("OnButtonEnter");
    // }
    // public void OnButtonUp()
    // {
    //     Debug.Log("OnButtonUp");
    // }

    public SteamVR_LaserPointer laserPointer;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Player")
        {
            PlayerOnClick.Invoke();
        }
        else if (e.target.name == "Introduction")
        {
            IntroductionOnClick.Invoke();
        }
        else if (e.target.name == "Exit")
        {

        }
        else if (e.target.name == "Ranking")
        {

        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Player")
        {
            PlayerOnEnter.Invoke();
        }
        else if (e.target.name == "Introduction")
        {
            IntroductionOnEnter.Invoke();
        }
        else if (e.target.name == "Exit")
        {

        }
        else if (e.target.name == "Ranking")
        {

        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Player")
        {
            PlayerOnUp.Invoke();
        }
        else if (e.target.name == "Introduction")
        {
            IntroductionOnUp.Invoke();
        }
        else if (e.target.name == "Exit")
        {

        }
        else if (e.target.name == "Ranking")
        {

        }
    }

}
