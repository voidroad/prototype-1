using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterControllerMonoBehaviour : MonoBehaviour, ICharacterStateMachine, IMoveable
{
    [SerializeField]
    private float jumpForce = 5f;

    [SerializeField]
    private float walkSpeed = 5f;

    [SerializeField]
    private float sprintSpeed = 10f;

    [SerializeField]
    private float rotateSpeed = 3f;

    private CharacerControls characterControls;

    private Rigidbody rigidBody;

    #region State

    private CharacterState CurrentState
    {
        get; set;
    }

    public void SetState(CharacterState state)
    {
        CurrentState = state;
    }

    private bool IsIdle
    {
        get { return CurrentState.GetType() == typeof(IdleCharacterState); }
    }

    private bool IsJumping
    {
        get { return CurrentState.GetType() == typeof(JumpingCharacterState); }
    }

    private bool IsWalking
    {
        get { return CurrentState.GetType() == typeof(WalkingCharacterState); }
    }

    private bool IsRotating
    {
        get { return CurrentState.GetType() == typeof(RotatingCharacterState); }
    }

    private bool IsSprinting
    {
        get { return CurrentState.GetType() == typeof(SprintingCharacterState); }
    }

    private bool IsStrafing
    {
        get { return CurrentState.GetType() == typeof(StrafingCharacterState); }
    }

    #endregion

    private void Awake()
    {
        CurrentState = new IdleCharacterState(this);
        characterControls = new CharacerControls();
        rigidBody = GetComponent<Rigidbody>();
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
        characterControls.Default.Jump.performed += ctx => Jump();
        characterControls.Default.Walk.performed += ctx => Move(ctx.ReadValue<float>());
        characterControls.Default.Strafe.performed += ctx => Turn(ctx.ReadValue<float>());
        characterControls.Default.SprintStart.performed += ctx => OnSprintStart();
        characterControls.Default.SprintEnd.performed += ctx => OnSprintEnd();
    }

    # region Movement

    public void Jump()
    {
        if (IsIdle)
        {
            CurrentState = new JumpingCharacterState(sprintSpeed, rigidBody, this);
        }

        CurrentState.Jump();
    }

    public void Move(float direction)
    {
        CurrentState.Move(direction);
    }

    public void Turn(float direction)
    {
        CurrentState.Turn(direction);
    }

    public void OnSprintStart()
    {
        if (IsIdle)
        {
            CurrentState = new RotatingCharacterState(sprintSpeed, this);
        }
        else
        {
            CurrentState = new SprintingCharacterState(sprintSpeed, rigidBody, this);
        }
    }

    public void OnSprintEnd()
    {
        if (IsIdle)
        {
            CurrentState = new StrafingCharacterState(walkSpeed, this);
        }
        else
        {
            CurrentState = new WalkingCharacterState(walkSpeed, rigidBody, this);
        }
    }

    # endregion
}
