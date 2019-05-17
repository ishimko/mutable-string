using System;
using NUnit.Framework;

namespace MutableString.Tests
{
    [TestFixture]
    public class MutableStringTests
    {
        [Test]
        public void ShouldChangeConstantString()
        {
            var mutableString = new MutableString("test");
            
            mutableString[0] = 'o';

            Assert.That("test", Is.EqualTo("teot"));
        }
    }
}