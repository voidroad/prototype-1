using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Voidroad.Prototype1;

namespace Tests
{
    public class DymmyPlayModeTest
    {
        private Dummy dummy;

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator DymmyTestWithEnumeratorPasses()
        {
            GameObject dummyGameObject = new GameObject();
            dummyGameObject.AddComponent<Dummy>();

            float initialYPos = dummyGameObject.transform.position.y;

            yield return new WaitForSeconds(.1f);

            Assert.Less(initialYPos, dummyGameObject.transform.position.y);

            yield return null;
        }
    }
}
