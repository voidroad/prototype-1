using UnityEngine;

class IdleCharacterState : CharacterState
{
    private Rigidbody rigidBody;

    public IdleCharacterState(Rigidbody rigidBody, ICharacterStateMachine characterStateMachine) : base(characterStateMachine)
    {
        this.rigidBody = rigidBody;
    }

    public override void Jump()
    {
        rigidBody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }

    public override void Move(Vector2 direction)
    {

    }

    public override void Turn(float direction)
    {

    }
}
