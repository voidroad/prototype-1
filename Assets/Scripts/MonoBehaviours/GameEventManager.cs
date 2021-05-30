using UnityEngine;

public class GameEventManager : MonoBehaviour
{
    private InMemoryGameEventManager Manager { get; set; }

    public GameEventManager()
    {
        Manager = InMemoryGameEventManager.Instance;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
