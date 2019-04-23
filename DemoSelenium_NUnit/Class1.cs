using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace Tests
{
    public class TestsBBC
    {
        EdgeDriver selenium;
        [SetUp]
        public void Setup()
        {
            selenium = new EdgeDriver();
            selenium.Navigate().GoToUrl("www.bbc.co.uk");


        }

        [Test]
        public void Test1()
        {
            string title = selenium.Title;
            Assert.AreEqual("BBC - Home", title);
        }

        [TearDown]
        public void Teardown()
        {
            selenium.Quit();
        }
    }
}