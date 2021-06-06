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
    }

    private void OnJump()
    {
        rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
    }
}

