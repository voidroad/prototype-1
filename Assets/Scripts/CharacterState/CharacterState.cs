using UnityEngine;

public abstract class CharacterState : IMoveable
{
    protected ICharacterStateMachine characterStateMachine;

    public CharacterState(ICharacterStateMachine characterStateMachine)
    {
        this.characterStateMachine = characterStateMachine;
    }

    public virtual void Attack() { }
    public virtual void Jump() { }
    public virtual void Move(Vector2 direction) { }
    public virtual void Turn(float direction) { }
}
