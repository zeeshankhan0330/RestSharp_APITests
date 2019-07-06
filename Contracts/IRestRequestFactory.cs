using RestSharp;

namespace APIs.Contracts
{
   public  interface IRestRequestFactory
   {
       IRestRequest GetRequest<T>(string url, Method method, T data, string oAuth);
       IRestRequest GetRequest(string url, Method method, string oAuth);
   }
}
