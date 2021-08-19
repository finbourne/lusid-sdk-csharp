using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials.HelloWorld
{
    [TestFixture]
    public class HelloWorldTest
    {
        [Test]
        public void Hello_World_Quick_Start()
        {
            var holdings = new Examples.HelloWorld().Run();
            Assert.That(holdings.Count, Is.EqualTo(1));
        }
    }
}