using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreInfoUI : MonoBehaviour {

    public GameObject moreInfoWW1;
    public GameObject moreInfoLocomotion;
    public GameObject moreInfoElementalBooth;
    public GameObject moreInfoVimyRidge;
    public GameObject moreInfoTheater;
    

    void Start () {
        if (moreInfoWW1)
            moreInfoWW1.SetActive(false);
        
        if (moreInfoLocomotion)
            moreInfoLocomotion.SetActive(false);
        
        if (moreInfoElementalBooth)
            moreInfoElementalBooth.SetActive(false);
        
        if (moreInfoVimyRidge)
            moreInfoVimyRidge.SetActive(false);
     
        if (moreInfoTheater)
            moreInfoTheater.SetActive(false);
    }

    public void ShowTheater()
    {
        if (!moreInfoTheater.activeInHierarchy && (moreInfoTheater.tag == "more-info-theater"))
        {
            Debug.Log("set panel to true");
            moreInfoTheater.SetActive(true);
            moreInfoElementalBooth.SetActive(false);
            moreInfoLocomotion.SetActive(false);
            moreInfoVimyRidge.SetActive(false);
            moreInfoWW1.SetActive(false);
        } else if (moreInfoTheater.activeInHierarchy)
        {
            moreInfoTheater.SetActive(false);
        }
    }

    public void ShowWW1()
    {
        if (!moreInfoWW1.activeInHierarchy && (moreInfoWW1.tag == "more-info-ww1"))
        {
            Debug.Log("set panel to true");
            moreInfoWW1.SetActive(true);
            moreInfoTheater.SetActive(false);
            moreInfoElementalBooth.SetActive(false);
            moreInfoLocomotion.SetActive(false);
            moreInfoVimyRidge.SetActive(false);
        }
        else if (moreInfoTheater.activeInHierarchy)
        {
            moreInfoWW1.SetActive(false);
        }
    }

    public void ShowLocomotion ()
    {
        if (!moreInfoLocomotion.activeInHierarchy && (moreInfoLocomotion.tag == "more-info-locomotion"))
        {
            Debug.Log("set panel to true");
            moreInfoLocomotion.SetActive(true);
            moreInfoTheater.SetActive(false);
            moreInfoElementalBooth.SetActive(false);
            moreInfoVimyRidge.SetActive(false);
            moreInfoWW1.SetActive(false);
        }
        else if (moreInfoTheater.activeInHierarchy)
        {
            moreInfoLocomotion.SetActive(false);
        }
    }

    public void ShowVimy()
    {
        if (!moreInfoVimyRidge.activeInHierarchy && (moreInfoVimyRidge.tag == "more-info-vimy"))
        {
            Debug.Log("set panel to true");
            moreInfoVimyRidge.SetActive(true);
            moreInfoTheater.SetActive(false);
            moreInfoElementalBooth.SetActive(false);
            moreInfoLocomotion.SetActive(false);
            moreInfoWW1.SetActive(false);
        }
        else if (moreInfoTheater.activeInHierarchy)
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
            moreInfoTheater.SetActive(false);
            moreInfoVimyRidge.SetActive(false);
            moreInfoLocomotion.SetActive(false);
            moreInfoWW1.SetActive(false);
        }
        else if (moreInfoTheater.activeInHierarchy)
        {
            moreInfoElementalBooth.SetActive(false);
        }
    }
}
