using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class CharacterControllerMonoBehaviour : MonoBehaviour, IMoveable
{
    [SerializeField]
    private float jumpForce = 5f;

    private CharacerControls characterControls;

    private Rigidbody rigidBody;

    private CharacterState currentState;

    private CharacterState CurrentState
    {
        set
        {
            if (currentState != null)
            {
                currentState.OnStateExit();
            }

            value.OnStateEnter();
            currentState = value;
        }
    }

    private bool IsIdle
    {
        get { return currentState.GetType() == typeof(IdleCharacterState); }
    }

    private bool IsJumping
    {
        get { return currentState.GetType() == typeof(JumpingCharacterState); }
    }

    private bool IsWalking
    {
        get { return currentState.GetType() == typeof(WalkingCharacterState); }
    }

    private void Awake()
    {
        characterControls = new CharacerControls();
        rigidBody = GetComponent<Rigidbody>();
        CurrentState = new IdleCharacterState(rigidBody);
    }

    private void OnEnable()
    {
        characterControls.Enable();
    } 

    private void OnDisable()
    {
        characterControls.Disable();
    }

    private void Start()
    {
        characterControls.Default.Jump.performed += ctx => OnJump();
        characterControls.Default.Walk.performed += ctx => OnWalk(ctx.ReadValue<float>());
        characterControls.Default.Strafe.performed += ctx => OnStrafe(ctx);
        characterControls.Default.SprintStart.performed += ctx => OnSprintStart(ctx);
        characterControls.Default.SprintEnd.performed += ctx => OnSprintEnd(ctx);
    }

    private void OnJump()
    {
        if (IsJumping)
        {
            return;
        }

        CurrentState = new JumpingCharacterState(jumpForce, rigidBody);
    }

    private void OnWalk(float direction)
    {
        if (IsWalking)
        {
            return;
        }

        CurrentState = new WalkingCharacterState(direction, rigidBody);
    }

    private void OnStrafe(UnityEngine.InputSystem.InputAction.CallbackContext ctx) { }

    private void OnSprintStart(UnityEngine.InputSystem.InputAction.CallbackContext ctx) { }

    private void OnSprintEnd(UnityEngine.InputSystem.InputAction.CallbackContext ctx) { }
}

