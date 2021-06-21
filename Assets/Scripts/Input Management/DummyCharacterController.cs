using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DummyCharacterController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;

    private CharacerControlls characterControlls;
    private Rigidbody rb;

    private void Awake()
    {
        characterControlls = new CharacerControlls();
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        characterControlls.Enable();
    }

    private void OnDisable()
    {
        characterControlls.Disable();
    }

    private void Start()
    {
        characterControlls.Default.Jump.performed += _ => OnJump();
        characterControlls.Default.Walk.performed += ctx => OnWalk(ctx.ReadValue<float>());
        characterControlls.Default.Strafe.performed += ctx => OnStrafe(ctx.ReadValue<float>());
        characterControlls.Default.SprintStart.performed += _ => Debug.Log("bool sprinting = true");
        characterControlls.Default.SprintEnd.performed += _ => Debug.Log("bool sprinting = false");
    }

    private void OnJump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnWalk(float value) { }         // Value = 1 if forwards, value = -1 if backwards

    private void OnStrafe(float value) { }        // Value = 1 if right, value = -1 if left
}

