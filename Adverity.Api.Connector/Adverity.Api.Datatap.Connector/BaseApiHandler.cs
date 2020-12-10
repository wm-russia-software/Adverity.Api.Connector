using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using RestSharp;

namespace Adverity.Api.Datatap.Connector
{
    /// <summary>
    /// Base api handler class
    /// </summary>
    public abstract class BaseApiHandler
    {
        #region Variables

        /// <summary>
        /// API url
        /// </summary>
        protected string ApiUrl { get; }

        /// <summary>
        /// Token
        /// </summary>
        protected string Token { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApiHandler"/> class.
        /// </summary>
        /// <param name="apiUrl">API url</param>
        /// <param name="token">Token</param>
        protected BaseApiHandler(string apiUrl, string token)
        {
            ApiUrl = apiUrl;
            Token = token;
        }

        #endregion

        #region Protected methods


        /// <summary>
        /// Gets data from API
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="url">Url</param>
        /// <param name="verb">Verb</param>
        /// <returns>Data of type T</returns>
        /// <exception cref="HttpRequestException">Unable to get data from Adverity Datatap API with method {verb}. Url: {url}</exception>
        protected T GetDataFromApi<T>(string url, Method verb = Method.GET)
        {
            RestClient client = new RestClient(url) { Timeout = -1 };
            RestRequest request = new RestRequest(verb);
            request.AddHeader("Authorization", $"Token {Token}");

            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<T>(response.Content);
            else
                throw new HttpRequestException($"Unable to get data from Adverity Datatap API with method {verb}. Url: {url}");
        }

        /// <summary>
        /// Gets data from API
        /// </summary>
        /// <param name="url">Url</param>
        /// <param name="verb">Verb</param>
        /// <returns>Data from api as string</returns>
        /// <exception cref="HttpRequestException">Unable to get data from Adverity Datatap API with method {verb}. Url: {url}</exception>
        protected string GetDataFromApi(string url, Method verb = Method.GET)
        {
            RestClient client = new RestClient(url) { Timeout = -1 };
            RestRequest request = new RestRequest(verb);
            request.AddHeader("Authorization", $"Token {Token}");

            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            else
                throw new HttpRequestException($"Unable to get data from Adverity Datatap API with method {verb}. Url: {url}");
        }

        #endregion
    }
}
