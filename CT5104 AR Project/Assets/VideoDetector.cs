using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoDetector : MonoBehaviour
{
    public GameObject reactorVideo;
    public GameObject reactorPlayer;
    public GameObject coolingTowerVideo;
    public GameObject coolingTowerPlayer;
    public GameObject ARCamera;
    public GameObject MainCamera;

    public void DetectedReactor()
    {
        reactorVideo.SetActive(true);
        reactorPlayer.SetActive(true);
        ARCamera.GetComponent<Camera>().enabled = false;
        MainCamera.GetComponent<Camera>().enabled = true;
        Debug.Log("Detected");
        StartCoroutine(waitingReactor());
    }

    public void DetectedCoolingTower()
    {
        coolingTowerVideo.SetActive(true);
        coolingTowerPlayer.SetActive(true);
        ARCamera.GetComponent<Camera>().enabled = false;
        MainCamera.GetComponent<Camera>().enabled = true;
        Debug.Log("Detected");
        StartCoroutine(waitingCoolingTower());
    }

    IEnumerator waitingReactor()
    {
        yield return new WaitForSeconds(79);

        reactorVideo.SetActive(false);
        reactorPlayer.SetActive(false);
        ARCamera.GetComponent<Camera>().enabled = true;
        MainCamera.GetComponent<Camera>().enabled = false;
    }

    IEnumerator waitingCoolingTower()
    {
        yield return new WaitForSeconds(51);

        coolingTowerVideo.SetActive (false);
        coolingTowerPlayer.SetActive (false);
        ARCamera.GetComponent<Camera>().enabled = true;
        MainCamera.GetComponent<Camera>().enabled = false;
    }
}
