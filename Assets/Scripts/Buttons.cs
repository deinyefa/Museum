using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Buttons : MonoBehaviour {

    public Canvas introductoryCanvas;
    public GameObject player;

    float increment = 87.73f;
    private bool moving = false;

    void Start ()
    {
        
    }

	public void StartTutorial ()
    {
        introductoryCanvas.enabled = !introductoryCanvas.enabled;
    }

    public void DashMove()
    {
        float camX = Camera.main.transform.position.x;
        float camY = Camera.main.transform.position.y;
        float camZ = Camera.main.transform.position.z;
        moving = true;

        iTween.MoveTo(player,
            iTween.Hash(
                "position", new Vector3(camX, camY, camZ + increment),
                "time", .55F,
                "easetype", "linear"
            )
        );
    }
}
