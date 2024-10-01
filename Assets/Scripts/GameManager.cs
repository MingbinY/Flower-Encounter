using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool grassIsAlive = true;

    public Material daySkybox;
    public Material nightSkybox;
    public GameObject sun;

    public void GrassDie()
    {
        grassIsAlive = false;
    }

    public void ChangeToNightSkyBox()
    {
        RenderSettings.skybox = nightSkybox;
        sun.SetActive(false);
        FindObjectOfType<LightController>().TurnOnLight();
    }
}
