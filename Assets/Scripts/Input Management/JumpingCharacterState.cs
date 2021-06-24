using UnityEngine;

class JumpingCharacterState : CharacterState
{
    private float jumpForce;

    public JumpingCharacterState(float jumpForce, Rigidbody rigidbody) : base(rigidbody)
    {
        this.jumpForce = jumpForce;
    }

    override public void OnStateEnter()
    {
        rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    override public void OnStateExit()
    {

    }
}
