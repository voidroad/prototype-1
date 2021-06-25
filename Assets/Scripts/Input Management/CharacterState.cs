public abstract class CharacterState : IMoveable
{
    protected ICharacterStateMachine characterStateMachine;

    public CharacterState(ICharacterStateMachine characterStateMachine)
    {
        this.characterStateMachine = characterStateMachine;
    }

    public virtual void Jump() { }

    public virtual void Move(float direction) { }

    public virtual void OnSprintEnd(float direction) { }

    public virtual void OnSprintStart(float direction) { }

    public virtual void Turn(float direction) { }
}
