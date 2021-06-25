using UnityEngine;

class IdleCharacterState : CharacterState
{
    public IdleCharacterState(ICharacterStateMachine characterStateMachine) : base(characterStateMachine) { }

    public override void Jump()
    {
        Debug.Log("IDLE jump");
    }
}
