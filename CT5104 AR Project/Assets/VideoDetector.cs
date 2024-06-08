using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoDetector : MonoBehaviour
{
    public GameObject video;
    public GameObject ARCamera;

    public void Detected()
    {
        video.SetActive(true);
        ARCamera.SetActive(false);
        Debug.Log("Detected");
    }

    public void Undetected()
    {
        video?.SetActive(false);
        Debug.Log("Undetected");
    }
}
