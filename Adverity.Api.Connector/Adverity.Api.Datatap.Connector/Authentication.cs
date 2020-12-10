using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Ak.Framework.Core.Helpers;
using Newtonsoft.Json;
using RestSharp;

namespace Adverity.Api.Datatap.Connector
{
    /// <summary>
    /// Authentication handler
    /// </summary>
    public class Authentication
    {
        #region Variables

        /// <summary>
        /// API url
        /// </summary>
        private readonly string _apiUrl;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Authentication"/> class.
        /// </summary>
        /// <param name="apiUrl">API url</param>
        public Authentication(string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Getting token
        /// </summary>
        /// <param name="userName">User name</param>
        /// <param name="password">Password</param>
        /// <returns>Token</returns>
        /// <exception cref="HttpRequestException">Unable to get an access token to Adverity Datatap API.</exception>
        public string GetToken(string userName, string password)
        {
            string url = UrlHelper.CombineUrls(_apiUrl, @"api/auth/token/");
            RestClient client = new RestClient(url) { Timeout = -1};
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("username", userName);
            request.AddParameter("password", password);

            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            else
                throw new HttpRequestException("Unable to get an access token to Adverity Datatap API.");
        }

        /// <summary>
        /// Getting a list of API endpoints
        /// </summary>
        /// <param name="token">Token</param>
        /// <returns>List of endpoints</returns>
        /// <exception cref="HttpRequestException">Unable to get a list of endpoints to Adverity Datatap API.</exception>
        public Dictionary<string, string> GetEndpointsList(string token)
        {
            string url = UrlHelper.CombineUrls(_apiUrl, @"api/");
            RestClient client = new RestClient(url) { Timeout = -1 };
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Token {token}");

            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            else
                throw new HttpRequestException("Unable to get a list of endpoints to Adverity Datatap API.");
        }

        #endregion
    }
}
