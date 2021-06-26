using UnityEngine;

interface IMoveable
{
    public void Jump();
    
    public void Move(Vector2 direction);

    public void Turn(float direction);
}
