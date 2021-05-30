using System;

interface IGameEventManager<K, T>
{
    abstract void subscribe(K eventKey, T action);

    abstract void unsubscribe(K eventKey, T action);

    abstract void notify(K eventKey);
}
