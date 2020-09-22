using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonScript : MonoBehaviour
{
    //We go ahead and put the variables we'll need for the code
    public GameObject door;
    public GameObject door1;
    public GameObject bigButton;

    //We will need to find the DoorScript and access it, so we make a reference to it
    DoorScript doorScript;
    DoorScript doorScript1;

    //We need to know if the Functions in DoorScript have been triggered or not in order to know *which* Function to invoke
    public bool hasTriggered;

    private void Start()
    {
        //We go fetch our components
        doorScript = GameObject.Find("Door").GetComponent<DoorScript>();
        doorScript1 = GameObject.Find("Door1").GetComponent<DoorScript>();

        //We set the Trigger to false, as nothing has happened yet
        hasTriggered = false;
    }

    //Now we check if there is a collision with the object
    private void OnCollisionEnter(Collision collision)
    {
        //If there is, we check if it's either the Box or the Capsule that has touched it. We also need to know if it was already touched before.
        if ((collision.collider.CompareTag("Box") || collision.collider.CompareTag("Capsule")) && !hasTriggered)
        {
            //If it's the Box or the Capsule, we make the button move a bit and make sure we know it has been triggered
            hasTriggered = true;
            transform.DOPunchScale(new Vector3(0.5f, 0f, 0.5f), 1f);
            //Depending on if their Box Collider Component is enabled or not, we either fade in or fade out the doors
            if (door.GetComponent<BoxCollider>().enabled)
            {
                doorScript.FadeOut();
            }
            else
            {
                doorScript.FadeIn();
            }

            if (door1.GetComponent<BoxCollider>().enabled)
            {
                doorScript1.FadeOut();
            }
            else
            {
                doorScript1.FadeIn();
            }
        }
    }

    //When the collision ends with either the Box or the Capsule, we set the button to have not been triggered
    private void OnCollisionExit(Collision collision)
    {
        if ((collision.collider.CompareTag("Box") || collision.collider.CompareTag("Capsule")) && hasTriggered)
        {
            hasTriggered = false;
        }
    }
}
