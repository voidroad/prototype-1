using UnityEngine;

namespace Voidroad.Prototype1
{
    interface IMoveable
    {
        void Attack();

        void Jump();

        void Move(Vector2 direction);
    }
}
