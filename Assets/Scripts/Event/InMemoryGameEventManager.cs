using System;
using System.Collections.Generic;
using UnityEngine;

public class InMemoryGameEventManager : Singleton<InMemoryGameEventManager>, IGameEventManager<Enum, Action<object>>
{
    private Dictionary<Enum, Action<object>> events = new Dictionary<Enum, Action<object>>();

    public void subscribe(Enum eventKey, Action<object> action)
    {
        Action<object> thisAction;

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

    public void unsubscribe(Enum eventKey, Action<object> action)
    {
        Action<object> thisAction;

        if (Instance.events.TryGetValue(eventKey, out thisAction))
        {
            thisAction -= action;
            Instance.events[eventKey] = thisAction;
        }
    }

    public void notify(Enum eventKey)
    {
        Action<object> action;

        if (Instance.events.TryGetValue(eventKey, out action))
        {
            action?.Invoke(eventKey);
        }
    }
}
