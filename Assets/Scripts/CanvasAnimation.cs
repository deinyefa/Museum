using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAnimation : MonoBehaviour {

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        anim.SetBool("ReticleViewing", true);
    }

    public void StopAnimation ()
    {
        anim.SetBool("ReticleViewing", false);
    }
}
