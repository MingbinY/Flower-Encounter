using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxTrigger : MonoBehaviour
{
    bool triggered = false;

    public GameObject boss;
    public GameObject bossGrass;
    public float bossWaitTime = 3.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;

        if (other.GetComponent<PlayerMovement>())
        {
            triggered = true;
            FindObjectOfType<GameManager>().ChangeToNightSkyBox();
            StartCoroutine(BossShowUp());
        }
    }

    IEnumerator BossShowUp()
    {
        yield return new WaitForSeconds(bossWaitTime);
        bossGrass.SetActive(false);
        boss.SetActive(true);
    }
}
