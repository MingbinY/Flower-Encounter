using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    public GameObject alive;
    public GameObject dead;

    GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        alive.SetActive(gm.grassIsAlive ?  true : false);
        dead.SetActive(gm.grassIsAlive ? false : true);
    }
}
