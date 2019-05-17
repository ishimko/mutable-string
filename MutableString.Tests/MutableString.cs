using System;
using NUnit.Framework;

namespace MutableString.Tests
{
    [TestFixture]
    public class MutableStringTest
    {
        [Test]
        public void ShouldChangeString()
        {
            var mutableString = new MutableString("test");
            
            mutableString[0] = 'o';

            Assert.That("test", Is.EqualTo("teot"));
        }
    }
}