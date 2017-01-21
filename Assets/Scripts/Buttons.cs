using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Buttons : MonoBehaviour {

    public Canvas introductoryCanvas;
    public Canvas tutorialCanvas;
    public GameObject player;
    
    private bool moving = false;

	public void StartTutorial ()
    {
        introductoryCanvas.enabled = !introductoryCanvas.enabled;
    }

    public void StartExperience ()
    {
        tutorialCanvas.enabled = !tutorialCanvas.enabled;
    }

    public void DashMove()
    {
        float camX = Camera.main.transform.position.x;
        float camY = Camera.main.transform.position.y;
        float camZ = Camera.main.transform.position.z;
        moving = true;

        iTween.MoveTo(player,
            iTween.Hash(
                "position", new Vector3(camX, camY, camZ + 87.73f),
                "time", .75F,
                "easetype", "linear"
            )
        );
    }

    public void DashMove1()
    {
        float camX = Camera.main.transform.position.x;
        float camY = Camera.main.transform.position.y;
        float camZ = Camera.main.transform.position.z;
        moving = true;

        iTween.MoveTo(player,
            iTween.Hash(
                "position", new Vector3(camX, camY, camZ + 102.16f),
                "time", .55F,
                "easetype", "linear"
            )
        );
    }
}
