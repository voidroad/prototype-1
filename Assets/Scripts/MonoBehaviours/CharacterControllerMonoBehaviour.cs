using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
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

    private bool IsWalking
    {
        get { return CurrentState.GetType() == typeof(WalkingCharacterState); }
    }

    private bool IsSprinting
    {
        get { return CurrentState.GetType() == typeof(SprintingCharacterState); }
    }

    #endregion

    # region Monobehaviour

    private void Awake()
    {
        CurrentState = new WalkingCharacterState(walkSpeed, GetComponent<Rigidbody>(), this);
    }

    private void OnEnable()
    {
        playerInput.actions.Enable();
    }

    private void OnDisable()
    {
        playerInput.actions.Disable();
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

    #endregion

    #region Input Events

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (!context.performed)
        {
            return;
        }

        Attack();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (!context.performed)
        {
            return;
        }
        
        Jump();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Move(context.ReadValue<Vector2>());
    }
    
    public void OnShiftPress(InputAction.CallbackContext context)
    {
        CurrentState = new SprintingCharacterState(sprintSpeed, GetComponent<Rigidbody>(), this);
    }

    public void OnShiftRelease(InputAction.CallbackContext context)
    {
        CurrentState = new WalkingCharacterState(walkSpeed, GetComponent<Rigidbody>(), this);
    }

    # endregion
}
