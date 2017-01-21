using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreInfoUI : MonoBehaviour {

    private GameObject moreInfoWW1;
    private GameObject moreInfoLocomotion;
    private GameObject moreInfoElementalBooth;
    private GameObject moreInfoVimyRidge;
    private GameObject moreInfoTheater;
    


    void Start () {
        moreInfoWW1 = GameObject.FindGameObjectWithTag("more-info-ww1");
        if (moreInfoWW1)
            moreInfoWW1.SetActive(false);

        moreInfoLocomotion = GameObject.FindGameObjectWithTag("more-info-locomotion");
        if (moreInfoLocomotion)
            moreInfoLocomotion.SetActive(false);

        moreInfoElementalBooth = GameObject.FindGameObjectWithTag("more-info-elemental");
        if (moreInfoElementalBooth)
            moreInfoElementalBooth.SetActive(false);
        
        moreInfoVimyRidge = GameObject.FindGameObjectWithTag("more-info-vimy");
        if (moreInfoVimyRidge)
            moreInfoVimyRidge.SetActive(false);
     
        moreInfoTheater = GameObject.FindGameObjectWithTag("more-info-theater");
        if (moreInfoTheater)
            moreInfoTheater.SetActive(false);
    }

    public void ShowTheater()
    {
        if (!moreInfoTheater.activeInHierarchy && (moreInfoTheater.tag == "more-info-theater"))
        {
            Debug.Log("set panel to true");
            moreInfoTheater.SetActive(true);
        }
    }

    public void ShowWW1()
    {
        if (!moreInfoWW1.activeInHierarchy && (moreInfoWW1.tag == "more-info-ww1"))
        {
            Debug.Log("set panel to true");
            moreInfoWW1.SetActive(true);
        }
    }

    public void ShowLocomotion ()
    {
        if (!moreInfoLocomotion.activeInHierarchy && (moreInfoLocomotion.tag == "more-info-locomotion"))
        {
            Debug.Log("set panel to true");
            moreInfoLocomotion.SetActive(true);
        }
    }

    public void ShowVimy()
    {
        if (!moreInfoVimyRidge.activeInHierarchy && (moreInfoVimyRidge.tag == "more-info-vimy"))
        {
            Debug.Log("set panel to true");
            moreInfoVimyRidge.SetActive(true);
        } else if (moreInfoVimyRidge.activeInHierarchy)
        {
            moreInfoVimyRidge.SetActive(false);
        }
    }

    public void ShowElementalBooth()
    {
        if (!moreInfoElementalBooth.activeInHierarchy && (moreInfoElementalBooth.tag == "more-info-elemental"))
        {
            Debug.Log("set panel to true");
            moreInfoElementalBooth.SetActive(true);
        }
    }
}
