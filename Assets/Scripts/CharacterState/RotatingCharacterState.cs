using UnityEngine;

class RotatingCharacterState : CharacterState
{
    private float speed;

    public RotatingCharacterState(float speed, ICharacterStateMachine characterStateMachine) : base(characterStateMachine)
    {
        this.speed = speed;
    }

    override public void Turn(float direction)
    {
        Debug.Log("Rotating in " + direction + " direction with speed of " + speed);
    }
}
