using RestSharp;

namespace APIs.Contracts
{
   public interface IRestClientFactory
   {
       IRestClient Create(string baseUrl);
   }
}
