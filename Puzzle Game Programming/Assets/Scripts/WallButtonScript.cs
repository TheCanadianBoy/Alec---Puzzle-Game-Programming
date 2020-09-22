using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallButtonScript : MonoBehaviour
{
    //We go ahead and put the variables we'll need for the code
    BridgeScript bridgeScript;
    public GameObject player;

    private void Start()
    {
        //We need to find the BridgeScript to be able to use it in our Function
        bridgeScript = GameObject.Find("Bridge").GetComponent<BridgeScript>();
    }

    //We check if something is triggered the object's Box Collider
    private void OnTriggerStay(Collider other)
    {
        //If it's the Capsule and it presses E, we tell the bridge to Fade
        if (other.gameObject.tag == "Capsule" && Input.GetKeyDown(KeyCode.E))
        {
            bridgeScript.FadeBridge();
        }
    }

}
