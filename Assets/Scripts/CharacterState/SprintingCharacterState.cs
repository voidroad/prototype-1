using UnityEngine;

class SprintingCharacterState : CharacterState
{
    private float speed;

    private Rigidbody rigidBody;

    public SprintingCharacterState(float speed, Rigidbody rigidBody, ICharacterStateMachine characterStateMachine) : base(characterStateMachine)
    {
        this.speed = speed;
        this.rigidBody = rigidBody;
    }

    override public void Move(Vector2 direction)
    {
        rigidBody.AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }
}
