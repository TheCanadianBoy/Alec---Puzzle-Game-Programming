using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    //When something collides with this object, we instanciate the OnWin Function from the Singleton in GameManager
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        GameManager.Instance.OnWin();
    }
}
