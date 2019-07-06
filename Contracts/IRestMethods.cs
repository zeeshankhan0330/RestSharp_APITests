using System.Collections.Generic;
using RestSharp;

namespace APIs.Contracts
{
    public interface IRestMethods
    {
        IRestResponse Post<T>(string url, T data);

        IRestResponse Put<T>(string url, T data);

        IRestResponse Put(string url);

        IRestResponse Post<T>(string url, List<T> data);

        IRestResponse Get(string url);

    }
}
