using UnityEngine;

public class GameEventManager : MonoBehaviour
{
    private InMemoryGameEventManager Manager { get; set; }

    public GameEventManager()
    {
        Manager = InMemoryGameEventManager.Instance;
    }
}
