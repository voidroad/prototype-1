using UnityEngine;

class IdleCharacterState : CharacterState
{
    public IdleCharacterState(Rigidbody rigidBody) : base(rigidBody) { }

    override public void OnStateEnter() { }

    override public void OnStateExit() { }
}
