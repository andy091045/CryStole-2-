using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class ShockController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SteamVR_Actions.default_Haptic.Execute(0, 0.2f, 1, 5, SteamVR_Input_Sources.RightHand);
    }
}
