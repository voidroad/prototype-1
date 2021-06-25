using UnityEngine;

class WalkingCharacterState : CharacterState
{
    private float speed;

    private Rigidbody rigidBody;

    public WalkingCharacterState(float speed, Rigidbody rigidBody, ICharacterStateMachine characterStateMachine) : base(characterStateMachine)
    {
        this.speed = speed;
        this.rigidBody = rigidBody;
    }

    override public void Move(float direction)
    {
        rigidBody.AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }
}
