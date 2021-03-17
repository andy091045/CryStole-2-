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
    private PointerEventArgs pointerEventArgs;
    public SteamVR_LaserPointer SteamVrLaserPointer;
    public UnityEvent mOnEnter = null;
    public UnityEvent mOnClick = null;
    public UnityEvent mOnUp = null;
    void Start()
    {
        mOnEnter.AddListener(OnButtonEnter);
        mOnClick.AddListener(OnButtonClick);
        mOnUp.AddListener(OnButtonUp);
    }

    void OnEnable()
    {
        SteamVrLaserPointer.PointerClick += SteamVrLaserPointerClick;
        SteamVrLaserPointer.PointerIn += SteamVrLaserPointerIn;
        SteamVrLaserPointer.PointerOut += SteamVrLaserPointerOut;
    }

    void OnDestroy()
    {
        SteamVrLaserPointer.PointerClick -= SteamVrLaserPointerClick;
        SteamVrLaserPointer.PointerIn -= SteamVrLaserPointerIn;
        SteamVrLaserPointer.PointerOut -= SteamVrLaserPointerOut;
    }

    private void SteamVrLaserPointerOut(object sender, PointerEventArgs e)
    {
        if (e.target.gameObject == this.gameObject)
        {
            if (mOnUp != null) mOnUp.Invoke();
        }
    }

    private void SteamVrLaserPointerIn(object sender, PointerEventArgs e)
    {
        if (e.target.gameObject == this.gameObject)
        {
            if (mOnEnter != null) mOnEnter.Invoke();
        }
    }

    private void SteamVrLaserPointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.gameObject == this.gameObject)
        {
            if (mOnClick != null) mOnClick.Invoke();
        }
    }

    public void OnButtonClick()
    {
        Debug.Log("OnButtonClick");
    }
    public void OnButtonEnter()
    {
        Debug.Log("OnButtonEnter");
    }
    public void OnButtonUp()
    {
        Debug.Log("OnButtonUp");
    }

}
