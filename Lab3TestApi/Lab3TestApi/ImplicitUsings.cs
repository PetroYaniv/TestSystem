using Lab3TestApi.StepDefinitions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace SeleniumNunit
{
    [TestFixture]
    public class ExampleTest
    {
        ApiStepDefinitions apiStepDefinitions = new ApiStepDefinitions();
        TestGithubDefinitions testGithubDefinitions = new TestGithubDefinitions();


        [Test]
        public void ApiTestPost()
        {
            
            Assert.AreEqual(200, apiStepDefinitions.POSTtest());

        }
        [Test]
        public void ApiTestGet()
        {
            
            Assert.AreEqual(200, apiStepDefinitions.GETtest());

        }

        [Test]
        public void ApiTestPut()
        {

            Assert.AreEqual(200, apiStepDefinitions.PUTtest());

        }

        [Test]
        public void ApiTestDelete()
        {

            Assert.AreEqual(201, apiStepDefinitions.DELETEtest());

        }


        [Test]
        public void ApiTestDetGithub()
        {

            Assert.AreEqual(200, testGithubDefinitions.GETtest());

        }


    }
}
