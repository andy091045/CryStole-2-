using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class ShockController : MonoBehaviour
{ 
    public static ShockController Instance;
    void Awake(){
        Instance = this;
    }
    public void Shock(float f,int n){
        if(n==1){
            //右手
             SteamVR_Actions.default_Haptic.Execute(0, f, 1, 5, SteamVR_Input_Sources.RightHand);
        }else{
            //左手
             SteamVR_Actions.default_Haptic.Execute(0, f, 1, 5, SteamVR_Input_Sources.LeftHand);
        }
    }
}
