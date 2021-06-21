using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventManagerMonoBehaviour : MonoBehaviour
{
    private InMemoryGameEventManager Manager { get; set; }

    public GameEventManagerMonoBehaviour()
    {
        Manager = InMemoryGameEventManager.Instance;
    }
}
