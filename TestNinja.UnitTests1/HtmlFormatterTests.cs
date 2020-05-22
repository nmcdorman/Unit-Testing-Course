using System;
using TestNinja.Fundamentals;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace TestNinja.UnitTests1
{
    //  [TestClass] MSTest attribute
    [TestFixture]   // NUnit framework
    public class HtmlFormatterTests
    {
        //[TestMethod]  MSTest attribute
        [Test]  // NUnit
        public void FormatAsBold_WhenCalled_ReturnsStringEnclosedWithStrongElement()
        {            
            //  Arrange     //  where you initialize objects
            var formatter = new HtmlFormatter();

            //  Act
            var result = formatter.FormatAsBold("abc");

            //  Assert  //  Many options for Assert, personal preference            
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //  More general assertion
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));
        }
    }
}
