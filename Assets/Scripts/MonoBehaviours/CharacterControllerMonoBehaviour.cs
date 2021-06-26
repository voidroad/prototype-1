using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class CharacterControllerMonoBehaviour : MonoBehaviour, ICharacterStateMachine, IMoveable
{
    # region Fields And Properties

    [SerializeField]
    private PlayerInput playerInput;

    [SerializeField]
    private float jumpForce = 5f;

    [SerializeField]
    private float walkSpeed = 5f;

    [SerializeField]
    private float sprintSpeed = 10f;

    [SerializeField]
    private float rotateSpeed = 3f;

    #endregion

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

    # region Monobehaviour

    private void Awake()
    {
        CurrentState = new IdleCharacterState(this);
    }

    private void OnEnable()
    {
        playerInput.actions.Enable();

        Debug.Log("enable" + playerInput.isActiveAndEnabled);
    }

    private void OnDisable()
    {
        playerInput.actions.Disable();

        Debug.Log("disable" + playerInput.isActiveAndEnabled);
    }

    #endregion

    # region Movement

    public void Attack()
    {
        CurrentState.Attack();
    }

    public void Jump()
    {
        CurrentState.Jump();
    }

    public void Move(Vector2 direction)
    {
        CurrentState.Move(direction);
    }

    public void Turn(float direction)
    {
        CurrentState.Turn(direction);
    }

    #endregion

    #region Input Events

    public void OnAttack(InputAction.CallbackContext context)
    {
        Debug.Log("on attack");
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("on jump");
        
        Jump();
    }

    public void OnForward(InputAction.CallbackContext context)
    {
        Debug.Log("on forward");

        Move(new Vector2(0, context.ReadValue<float>()));
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        Debug.Log("on sprint");

        Move(new Vector2(0, context.ReadValue<float>()));
    }

    public void OnTurn(InputAction.CallbackContext context)
    {
        Debug.Log("on turn");

        Turn(context.ReadValue<float>());
    }

    public void OnStrafe(InputAction.CallbackContext context)
    {
        Debug.Log("on strafe");

        Turn(context.ReadValue<float>());
    }

    # endregion
}
