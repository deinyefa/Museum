using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreInfoUI : MonoBehaviour {

    public GameObject moreInfoWW1;
    public GameObject moreInfoLocomotion;
    public GameObject moreInfoElementalBooth;
    public GameObject moreInfoVimyRidge;
    public GameObject moreInfoTheater;

    private GvrAudioSource gvrAudioSource;
    public AudioClip warSound;

    void Start () {
        gvrAudioSource = GetComponent<GvrAudioSource>();

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
        if (!moreInfoTheater.activeInHierarchy && moreInfoTheater.tag == "more-info-theater" &&
            !moreInfoVimyRidge.activeInHierarchy && !moreInfoWW1.activeInHierarchy &&
                !moreInfoLocomotion.activeInHierarchy && !moreInfoElementalBooth.activeInHierarchy)
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
            gvrAudioSource.PlayOneShot(warSound, 0f);
        }
    }

    public void ShowWW1()
    {
        if (!moreInfoWW1.activeInHierarchy && moreInfoWW1.tag == "more-info-ww1" && 
            !moreInfoVimyRidge.activeInHierarchy && !moreInfoTheater.activeInHierarchy &&
                !moreInfoLocomotion.activeInHierarchy && !moreInfoElementalBooth.activeInHierarchy)
        {
            Debug.Log("set panel to true");
            moreInfoWW1.SetActive(true);
            moreInfoTheater.SetActive(false);
            moreInfoElementalBooth.SetActive(false);
            moreInfoLocomotion.SetActive(false);
            moreInfoVimyRidge.SetActive(false);

            gvrAudioSource.PlayOneShot(warSound, 0.5f);
        }
        else if (moreInfoWW1.activeInHierarchy)
        {
            moreInfoWW1.SetActive(false);
            gvrAudioSource.Stop();
//            gvrAudioSource.PlayOneShot(warSound, 0f);
        }
    }

    public void ShowLocomotion ()
    {
        if (!moreInfoLocomotion.activeInHierarchy && moreInfoLocomotion.tag == "more-info-locomotion" &&
            !moreInfoVimyRidge.activeInHierarchy && !moreInfoWW1.activeInHierarchy &&
                !moreInfoTheater.activeInHierarchy && !moreInfoElementalBooth.activeInHierarchy)
        {
            Debug.Log("set panel to true");
            moreInfoLocomotion.SetActive(true);
            moreInfoTheater.SetActive(false);
            moreInfoElementalBooth.SetActive(false);
            moreInfoVimyRidge.SetActive(false);
            moreInfoWW1.SetActive(false);
        }
        else if (moreInfoLocomotion.activeInHierarchy)
        {
            moreInfoLocomotion.SetActive(false);
            gvrAudioSource.PlayOneShot(warSound, 0f);
        }
    }

    public void ShowVimy()
    {
        if (!moreInfoVimyRidge.activeInHierarchy && (moreInfoVimyRidge.tag == "more-info-vimy") &&
            !moreInfoTheater.activeInHierarchy && !moreInfoWW1.activeInHierarchy &&
                !moreInfoLocomotion.activeInHierarchy && !moreInfoElementalBooth.activeInHierarchy)
        {
            Debug.Log("set panel to true");
            moreInfoVimyRidge.SetActive(true);
            moreInfoTheater.SetActive(false);
            moreInfoElementalBooth.SetActive(false);
            moreInfoLocomotion.SetActive(false);
            moreInfoWW1.SetActive(false);

            gvrAudioSource.PlayOneShot(warSound, 0.5f);
        }
        else if (moreInfoVimyRidge.activeInHierarchy)
        {
            moreInfoVimyRidge.SetActive(false);
            gvrAudioSource.Stop();
//            gvrAudioSource.PlayOneShot(warSound, 0f);
        }
    }

    public void ShowElementalBooth()
    {
        if (!moreInfoElementalBooth.activeInHierarchy && (moreInfoElementalBooth.tag == "more-info-elemental") &&
            !moreInfoVimyRidge.activeInHierarchy && !moreInfoWW1.activeInHierarchy &&
                !moreInfoTheater.activeInHierarchy && !moreInfoElementalBooth.activeInHierarchy)
        {
            Debug.Log("set panel to true");
            moreInfoElementalBooth.SetActive(true);
            moreInfoTheater.SetActive(false);
            moreInfoVimyRidge.SetActive(false);
            moreInfoLocomotion.SetActive(false);
            moreInfoWW1.SetActive(false);
            gvrAudioSource.PlayOneShot(warSound, 0f);
        }
        else if (moreInfoElementalBooth.activeInHierarchy)
        {
            moreInfoElementalBooth.SetActive(false);
        }
    }

    void WarSound()
    {
        if (moreInfoWW1.activeInHierarchy || moreInfoVimyRidge.activeInHierarchy)
        {
            gvrAudioSource.Play();
        }
    }
}
