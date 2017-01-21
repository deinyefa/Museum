using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAnimation : MonoBehaviour {

    private Animator anim;
    private Animator selectedAnim;

    void Start()
    {
        anim = GetComponent<Animator>();
        selectedAnim = GetComponentInChildren<Animator>();
    }

    public void StartAnimation()
    {
        anim.SetBool("ReticleViewing", true);
    }

    public void StopAnimation ()
    {
        anim.SetBool("ReticleViewing", false);
    }

    public void ShowMore ()
    {
        selectedAnim.SetBool("ClickedCanvas", true);
        Debug.Log("clicked canvas true");
    }

    public void RemovePanel ()
    {
        selectedAnim.SetBool("ClickedCanvas", false);
    }
}
