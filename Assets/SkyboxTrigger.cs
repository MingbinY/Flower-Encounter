using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxTrigger : MonoBehaviour
{
    bool triggered = false;

    public GameObject boss;
    public GameObject bossGrass;
    public float bossWaitTime = 3.0f;

    public ParticleSystem bossSpawnEffect;

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
        bossSpawnEffect.Play();
        yield return new WaitForSeconds(bossWaitTime);
        FindObjectOfType<BgmManager>().BossEncounter();
        bossGrass.SetActive(false);
        boss.SetActive(true);
        bossSpawnEffect.Stop();
        bossSpawnEffect.gameObject.SetActive(false);
    }
}
