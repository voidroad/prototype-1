namespace Voidroad.Prototype1
{
    interface IGameEventManager<K, T>
    {
        abstract void Subscribe(K eventKey, T action);

        abstract void Unsubscribe(K eventKey, T action);

        abstract void Notify(K eventKey);
    }
}
