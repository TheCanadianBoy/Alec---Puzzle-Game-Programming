using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickBox : MonoBehaviour
{
    //We go ahead and put the variables we'll need for the code
    public Transform pickUpTarget;
    public GameObject player;
    public bool isPickedUp;

    private void Start()
    {
        //At the start, we set the Box as not being picked up
        isPickedUp = false;
    }

    //We then check if something is triggering the Box Collider of the Object
    private void OnTriggerStay(Collider other)
    {
        //if the trigger comes from the Capsule and it presses down the E key while the Box isn't picked up, then we pick it up
        if (other.gameObject.tag == "Capsule" && Input.GetKeyDown(KeyCode.E) && isPickedUp == false)
        {
            //We set the gravity to false, transform its position to a point in front of the player, and make it a child so it moves with them
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = pickUpTarget.position;
            this.transform.parent = GameObject.Find("PickUpTarget").transform;
        }
        //Else, we put the box down
        else if (other.gameObject.tag == "Capsule" && !Input.GetKey(KeyCode.E))
        {
            GetComponent<Rigidbody>().useGravity = true;
            gameObject.transform.parent = null;
        }
    }
}
