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
    if(SteamVR_Actions.ChangeWeapon.Switch.GetStateDown(SteamVR_Input_Sources.Any)){
        Debug.Log("switch");
    }  
}
}
}