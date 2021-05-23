using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class DymmyEditModeTest
    {
        private Dummy dummy;

        // A Test behaves as an ordinary method
        [Test]
        public void DymmyTestSimplePasses()
        {
            GameObject dummyGameObject = new GameObject();
            dummy = dummyGameObject.AddComponent<Dummy>();

            Assert.AreEqual(3, dummy.Add(1, 2));
        }
    }
}
