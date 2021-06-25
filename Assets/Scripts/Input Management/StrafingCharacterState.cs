using UnityEngine;

class StrafingCharacterState : CharacterState
{
    private float speed;

    public StrafingCharacterState(float speed, ICharacterStateMachine characterStateMachine) : base(characterStateMachine)
    {
        this.speed = speed;
    }

    override public void Turn(float direction)
    {
        Debug.Log("Strafing in " + direction + " direction with speed of " + speed);
    }
}
