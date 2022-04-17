using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private bool isWin;
    private void OnTriggerEnter(Collider other)
    {
        var playerRigidbody = other.attachedRigidbody;
        if (playerRigidbody && playerRigidbody.CompareTag("Player"))
        {
            playerRigidbody.TryGetComponent(out PlayerController controller);
            playerRigidbody.TryGetComponent(out FinishGame finishGame);
            controller.IsCanMove = false;
            isWin = true;
            finishGame.StartFinish(isWin);
            playerRigidbody.isKinematic = true;
        }
    }
}
