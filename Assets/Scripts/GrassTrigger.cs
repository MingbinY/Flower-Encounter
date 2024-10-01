using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassTrigger : MonoBehaviour
{
    bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;

        if (other.GetComponent<PlayerMovement>() != null)
        {
            FindObjectOfType<GameManager>().GrassDie();
            triggered = true;
        }
    }


}
