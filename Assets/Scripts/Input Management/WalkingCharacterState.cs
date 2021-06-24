using UnityEngine;

class WalkingCharacterState : CharacterState
{
    private float direction;

    public WalkingCharacterState(float direction, Rigidbody rigidbody) : base(rigidbody)
    {
        this.direction = direction;
    }

    override public void OnStateEnter()
    {
        Debug.Log("Movin in " + direction + " direction");
    }

    override public void OnStateExit()
    {

    }
}
