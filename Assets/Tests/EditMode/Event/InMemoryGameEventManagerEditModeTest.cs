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

            Action actionDummy = delegate ()
            {
                dummy++;
            };

            subject.Subscribe(EventKey.Foo, actionDummy);
            Assert.AreEqual(0, dummy);
            subject.Notify(EventKey.Foo);
            Assert.AreEqual(1, dummy);
            subject.Unsubscribe(EventKey.Foo, actionDummy);
            subject.Notify(EventKey.Foo);
            Assert.AreEqual(1, dummy);
        }
    }
}
