using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorScript : MonoBehaviour
{
    //We want to be able to access the object's Mesh Renderer and Box Collider components
    public MeshRenderer m_Renderer;
    public BoxCollider b_Collider;

    //To fade out the door, we need to slowly remove its material, then disable it's box collider
    public void FadeOut()
    {
        m_Renderer.material.DOFade(0f, 2f);
        if(b_Collider.enabled)
        {
            b_Collider.enabled = false;
        }

    }

    //To fade in the door, we need to slowly fade in its material, then enable its box collider
    public void FadeIn()
    {
        m_Renderer.material.DOFade(1f, 2f);
        if(!b_Collider.enabled)
        {
            b_Collider.enabled = true;
        }

    }
}
