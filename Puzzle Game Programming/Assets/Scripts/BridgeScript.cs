using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BridgeScript : MonoBehaviour
{
    //We want to be able to access the object's Mesh Renderer and Box Collider components
    public MeshRenderer m_Renderer;
    public BoxCollider b_Collider;

    private bool hasFaded;


    private void Start()
    {
        //We find the Mesh Renderer component and start the game with it activated
        m_Renderer = GetComponent<MeshRenderer>();
        b_Collider = GetComponent<BoxCollider>();

        hasFaded = false;

    }
    public void FadeBridge()
    {
        //By pressing the button (in WallButtonScript) we either enable or disable the Box Collider component and either fade in or fade out the object's material
        if(!hasFaded)
        {
            m_Renderer.material.DOFade(0f, 2f);
            b_Collider.enabled = false;
            hasFaded = true;
        }
        else
        {
            m_Renderer.material.DOFade(1f, 2f);
            b_Collider.enabled = true;
            hasFaded = false;
        }
    }
        
}
