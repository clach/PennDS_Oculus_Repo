using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusController : MonoBehaviour {

    public OVRInput.Controller controller;

    //https://software.intel.com/en-us/articles/introduction-to-vr-creating-a-first-person-player-game-for-the-oculus-rift


    void Update () {
        //transform.localPosition = OVRInput.GetLocalControllerPosition(controller);
        //transform.localRotation = OVRInput.GetLocalControllerRotation(controller);
    }
}
