using NUnit.Framework;
using System;

namespace Tests
{
    public class InMemoryGameEventManagerEditModeTest
    {
        [Test]
        public void TestSingleton()
        {
            Assert.AreSame(InMemoryGameEventManager.Instance, InMemoryGameEventManager.Instance);
        }

        [Test]
        public void TestNotify()
        {
            int dummy = 0;
            InMemoryGameEventManager subject = new InMemoryGameEventManager();

            Action<object> actionDummy = delegate (object data)
            {
                dummy++;
            };

            subject.subscribe(EventKey.Foo, actionDummy);
            Assert.AreEqual(0, dummy);
            subject.notify(EventKey.Foo);
            Assert.AreEqual(1, dummy);
            subject.unsubscribe(EventKey.Foo, actionDummy);
            subject.notify(EventKey.Foo);
            Assert.AreEqual(1, dummy);
        }
    }
}
