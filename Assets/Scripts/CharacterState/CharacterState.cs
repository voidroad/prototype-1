using UnityEngine;

public abstract class CharacterState : IMoveable
{
    protected Rigidbody rigidBody;
    
    protected ICharacterStateMachine characterStateMachine;

    public CharacterState(Rigidbody rigidBody, ICharacterStateMachine characterStateMachine)
    {
        this.rigidBody = rigidBody;
        this.characterStateMachine = characterStateMachine;
    }

    public virtual void Attack() { }

    public virtual void Jump()
    {
        rigidBody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }

    public virtual void Move(Vector2 direction) { }
}
