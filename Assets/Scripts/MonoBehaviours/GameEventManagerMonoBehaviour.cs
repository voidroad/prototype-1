using UnityEngine;

namespace Voidroad.Prototype1
{
    public class GameEventManagerMonoBehaviour : MonoBehaviour
    {
        private InMemoryGameEventManager Manager { get; set; }

        public GameEventManagerMonoBehaviour()
        {
            Manager = InMemoryGameEventManager.Instance;
        }
    }
}
