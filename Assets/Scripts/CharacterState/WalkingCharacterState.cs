using UnityEngine;

namespace Voidroad.Prototype1
{
    class WalkingCharacterState : CharacterState
    {
        private float speed;

        public WalkingCharacterState(float speed, Rigidbody rigidBody, ICharacterStateMachine characterStateMachine) : base(rigidBody, characterStateMachine)
        {
            this.speed = speed;
        }

        override public void Move(Vector2 direction)
        {
            rigidBody.AddForce(new Vector3(direction.x, 0, direction.y) * speed, ForceMode.Impulse);
        }
    }
}
