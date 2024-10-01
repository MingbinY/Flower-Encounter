using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject lightBulb;
    public GameObject lightSource;

    public Material litMat;
    public Material unlitMat;

    private void Start()
    {
        TurnOffLight();
    }

    public void TurnOffLight()
    {
        lightBulb.GetComponent<MeshRenderer>().material = unlitMat;
        lightSource.SetActive(false);
    }

    public void TurnOnLight()
    {
        lightBulb.GetComponent<MeshRenderer>().material = litMat;
        lightSource.SetActive(true);
    }



}
