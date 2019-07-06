using System.Collections.Generic;
using APIs.Contracts;
using APIs.Factory;
using RestSharp;

namespace dh.MediaPlanner.APIs.Utility
{
    public class RestMethods : IRestMethods
    {
        private string OAuth = @"Bearer " + "";
        private string _baseUrl = @"";
        private readonly RestClienFactory _client;
        private readonly RestRequestFactory _request;

       
        public RestMethods(RestClienFactory client, RestRequestFactory request)
        {
            _client = client;
            _request = request;
        }


        public IRestResponse Post<T>(string url, T data)
        {
            var client = _client.Create(_baseUrl);
            var request = _request.GetRequest(url, Method.POST, data, OAuth);
            var response = client.Execute(request);
            return response;

        }

        public IRestResponse Get(string url)
        {
            var client = _client.Create(_baseUrl);
            var request = _request.GetRequest(url, Method.GET, OAuth);
            var response = client.Execute(request);
            return response;

        }

        public IRestResponse Post<T>(string url, List<T> data)
        {
            var client = _client.Create(_baseUrl);
            var request = _request.GetRequest(url, Method.POST, data, OAuth);
            var response = client.Execute(request);
            return response;
        }

        public IRestResponse Put<T>(string url, T data)
        {
            var client = _client.Create(_baseUrl);
            var request = _request.GetRequest(url, Method.PUT, data, OAuth);
            var response = client.Execute(request);
            return response;
        }

        public IRestResponse Put(string url)
        {
            var client = _client.Create(_baseUrl);
            var request = _request.GetRequest(url, Method.PUT, OAuth);
            var response = client.Execute(request);
            return response;

        }
    }
}
