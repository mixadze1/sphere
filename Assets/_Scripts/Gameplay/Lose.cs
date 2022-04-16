using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var playerRigidbody = other.attachedRigidbody;
        if (playerRigidbody && playerRigidbody.CompareTag("Player"))
        {
            playerRigidbody.TryGetComponent(out PlayerController controller);
            controller.IsFinish = true;

        }
    }
}
