using UnityEngine;

public class Lose : MonoBehaviour
{
    private bool isLose;
    private void OnTriggerEnter(Collider other)
    {
        var playerRigidbody = other.attachedRigidbody;

        if (playerRigidbody && playerRigidbody.CompareTag("Player"))
        {
            playerRigidbody.TryGetComponent(out PlayerController controller);
            playerRigidbody.TryGetComponent(out FinishGame finishGame);
            controller.IsCanMove = false;
            finishGame.StartFinish(isLose);
            playerRigidbody.isKinematic = true;
        }
    }
}
