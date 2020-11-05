//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

namespace Valve.VR.InteractionSystem.Sample
{
    public class SwitchWeapon : MonoBehaviour
    {
        public SteamVR_Action_Boolean SwitchAction;
     
private void Update(){
    if(SteamVR_Actions.ChangeWeapon.SwitchLeft.GetStateDown(SteamVR_Input_Sources.Any)){
        // Debug.Log(SteamVR_Actions.ChangeWeapon.Switch.GetStateDown(SteamVR_Input_Sources.Any));
      LeftWeapon.Instance.SwitchLeftEvent(true);      
       Debug.Log( LeftWeapon.Instance==null);
    }  
    if(SteamVR_Actions.ChangeWeapon.SwitchRight.GetStateDown(SteamVR_Input_Sources.Any)){
        // Debug.Log(SteamVR_Actions.ChangeWeapon.Switch.GetStateDown(SteamVR_Input_Sources.Any));
       RightWeapon.Instance.SwitchRightEvent(true);
       Debug.Log("Right");
    }  
}
}
}