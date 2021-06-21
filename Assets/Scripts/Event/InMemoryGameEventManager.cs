using System;
using System.Collections.Generic;
using UnityEngine;

public class InMemoryGameEventManager : Singleton<InMemoryGameEventManager>, IGameEventManager<Enum, Action>
{
    private Dictionary<Enum, Action> events = new Dictionary<Enum, Action>();

    public void Subscribe(Enum eventKey, Action action)
    {
        Action thisAction;

        if (Instance.events.TryGetValue(eventKey, out thisAction))
        {
            thisAction += action;
            Instance.events[eventKey] = thisAction;
        }
        else
        {
            thisAction += action;
            Instance.events.Add(eventKey, thisAction);
        }
    }

    public void Unsubscribe(Enum eventKey, Action action)
    {
        Action thisAction;

        if (Instance.events.TryGetValue(eventKey, out thisAction))
        {
            thisAction -= action;
            Instance.events[eventKey] = thisAction;
        }
    }

    public void Notify(Enum eventKey)
    {
        Action action;

        if (Instance.events.TryGetValue(eventKey, out action))
        {
            action?.Invoke(eventKey);
        }
    }
}
