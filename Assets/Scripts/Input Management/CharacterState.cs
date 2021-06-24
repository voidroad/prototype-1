using UnityEngine;

abstract class CharacterState : ICharacterState
{
    protected Rigidbody rigidBody;

    public CharacterState(Rigidbody rigidBody) {
        this.rigidBody = rigidBody;
    }

   abstract public void OnStateEnter();

   abstract public void OnStateExit();
}
