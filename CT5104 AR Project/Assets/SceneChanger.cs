using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ToCoolingTower()
    {
        SceneManager.LoadScene(1);
    }

    public void ToReactor()
    {
        SceneManager.LoadScene(0);
    }
}
