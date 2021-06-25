using UnityEngine;

class JumpingCharacterState : CharacterState
{
    private float force;

    private Rigidbody rigidBody;

    public JumpingCharacterState(float force, Rigidbody rigidBody, ICharacterStateMachine characterStateMachine) : base(characterStateMachine)
    {
        this.force = force;
        this.rigidBody = rigidBody;
    }

    override public void Jump()
    {
        rigidBody.AddForce(Vector3.up * force, ForceMode.Impulse);
    }
}
