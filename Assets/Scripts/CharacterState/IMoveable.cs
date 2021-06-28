using UnityEngine;

interface IMoveable
{
    public void Attack();

    public void Jump();
    
    public void Move(Vector2 direction);
}
