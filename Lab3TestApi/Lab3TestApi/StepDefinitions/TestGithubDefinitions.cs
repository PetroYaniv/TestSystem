using System;
using RestSharp;
using TechTalk.SpecFlow;

namespace Lab3TestApi.StepDefinitions
{
    [Binding]
    public sealed class TestGithubDefinitions
    {
        RestClient client = new RestClient("https://http.dog/200.jpg");

        [Given("github url http dog")]
        public string GoToURL()
        {
            string clientURL = "https://http.dog/200.jpg";
            return clientURL;

        }

        [Then("i test dog api method get")]
        public int GETtest()
        {
            RestRequest request = new RestRequest(this.GoToURL(), Method.Get);
            var response = client.Execute(request).StatusCode;
            return (int)response; // return 200
        }


    }
}
