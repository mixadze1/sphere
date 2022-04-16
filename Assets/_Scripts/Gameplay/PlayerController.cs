using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 speedWS;
    [SerializeField] private Vector3 speedAD;
    private bool oppositeSide;
    private bool isFinish;
    public bool IsFinish { get => isFinish; set => isFinish = value; }

    private void Awake()
    {
        rigidbody.position = startPosition;
        isFinish = true;
       
    }
    private void FixedUpdate()
    {
        if (!isFinish)
        {
            if (Input.GetKey(KeyCode.W))
            {
                MoveForward(oppositeSide = false);
            }
            if (Input.GetKey(KeyCode.S))
            {
                MoveForward(oppositeSide = true);
            }
            if (Input.GetKey(KeyCode.A))
            {
                MoveLeft(oppositeSide = false);
            }
            if (Input.GetKey(KeyCode.D))
            {
                MoveLeft(oppositeSide = true);
            }   
        }
    }
    private void MoveForward(bool oppositeSide) // 1 methodom cdelat
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
    private void MoveLeft(bool oppositeSide)
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
        isFinish = false;
        rigidbody.velocity = new Vector3(0,0,0);
        rigidbody.isKinematic = false;
        isFinish = true;
    } 
}