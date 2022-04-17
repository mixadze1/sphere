using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private ResultMenu resultMenu;
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 speedWS;
    [SerializeField] private Vector3 speedAD;
    private bool oppositeSide;
    private bool isCanMove;
    public bool IsCanMove { get => isCanMove; set => isCanMove = value; }

    private void Awake()
    {
        rigidbody.position = startPosition;
        isCanMove = false;

    }
    private void FixedUpdate()
    {
        if (isCanMove)
        {
            if (Input.GetKey(KeyCode.W))
            {
                MoveWS(oppositeSide = false);
            }
            if (Input.GetKey(KeyCode.S))
            {
                MoveWS(oppositeSide = true);
            }
            if (Input.GetKey(KeyCode.A))
            {
                MoveAD(oppositeSide = false);
            }
            if (Input.GetKey(KeyCode.D))
            {
                MoveAD(oppositeSide = true);
            }
            if (Input.GetKey(KeyCode.Escape))
            {
                resultMenu.Restart();
            }
        }
    }
    private void MoveWS(bool oppositeSide)
    {
        if (!oppositeSide)
        {
            rigidbody.velocity += speedWS;
        }

        else
        {
            rigidbody.velocity -= speedWS;
        }
    }
    private void MoveAD(bool oppositeSide)
    {
        if (!oppositeSide)
        {
            rigidbody.velocity += speedAD;
        }

        else
        {
            rigidbody.velocity -= speedAD;
        }
    }
    public void RestartGame()
    {
        rigidbody.isKinematic = true;
        rigidbody.position = startPosition;
        isCanMove = true;
        rigidbody.velocity = startPosition;
        rigidbody.isKinematic = false;
        isCanMove = false;
    }
}