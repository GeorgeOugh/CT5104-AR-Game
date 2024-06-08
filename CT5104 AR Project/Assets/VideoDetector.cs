using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoDetector : MonoBehaviour
{
    public GameObject reactorVideo;
    public GameObject coolingTowerVideo;
    public GameObject ARCamera;

    public bool isReactor;
    public bool isCoolingTower;

    public void Detected()
    {
        if (isReactor == true)
        {
            reactorVideo.SetActive(true);
            ARCamera.GetComponent<Camera>().enabled = false;
            Debug.Log("Detected");
        }

        if (isCoolingTower == true)
        {
            coolingTowerVideo.SetActive(true);
            ARCamera.GetComponent<Camera>().enabled = false;
            Debug.Log("Detected");
        }
    }

    public void Undetected()
    {
        ARCamera.GetComponent<Camera>().enabled = true;
        Debug.Log("Undetected");
    }
}
