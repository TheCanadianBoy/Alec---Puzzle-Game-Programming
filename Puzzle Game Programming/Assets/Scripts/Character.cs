using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //We go ahead and put the variables we'll need for the code
    public Rigidbody rgbd;
    public float speed = 5f;
    public float turnSpeed = 20f;
    public float jumpForce = 5f;


    void Update()
    {
        //Script for movement
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);

        transform.position = transform.position + movement * Time.deltaTime;


        //Script for jumping. We add Mathf to stop perfect inputs from resulting in infinite jumping
        if(Input.GetKeyDown(KeyCode.Space) && Mathf.Approximately(rgbd.velocity.y, 0f))
        {
            rgbd.AddForce(new Vector3(0, 1f * jumpForce, 0), ForceMode.Impulse);
        }         

    }

}
