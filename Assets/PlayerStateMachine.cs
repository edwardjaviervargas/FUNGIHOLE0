using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    public float walkSpeed = 3.0f;

    private Rigidbody2D rb;
    private PlayerState currentState = PlayerState.Idle;

    private enum PlayerState
    {
        Idle,
        Walking
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        switch (currentState)
        {
            case PlayerState.Idle:
                HandleIdleState();
                break;
            case PlayerState.Walking:
                HandleWalkingState();
                break;
        }
    }

    private void HandleIdleState()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            currentState = PlayerState.Walking;
        }
    }

    private void HandleWalkingState()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized * walkSpeed;
        rb.velocity = movement;

        if (horizontalInput == 0 && verticalInput == 0)
        {
            currentState = PlayerState.Idle;
        }
    }
}
