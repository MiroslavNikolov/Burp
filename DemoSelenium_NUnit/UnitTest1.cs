using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace Tests
{
    public class TestsGoogle
    {
        EdgeDriver selenium;
        [SetUp]
        public void Setup()
        {
            selenium = new EdgeDriver();
            selenium.Navigate().GoToUrl("www.google.co.uk");

             
        }

        [Test]
        public void Test1()
        {
            string title = selenium.Title;
             Assert.AreEqual("Google", title);
        }

        [TearDown]
        public void Teardown()
        {
            selenium.Quit();
        }
    }
}