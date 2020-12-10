using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Adverity.Api.Datatap.Connector.Models;
using Ak.Framework.Core.Helpers;
using RestSharp;

namespace Adverity.Api.Datatap.Connector
{
    /// <summary>
    /// Fetching handler
    /// </summary>
    public class Fetching : BaseApiHandler
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Fetching"/> class.
        /// </summary>
        /// <param name="apiUrl">API url</param>
        /// <param name="token">Token</param>
        public Fetching(string apiUrl, string token) : base(apiUrl, token)
        {
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Starts data fetching
        /// </summary>
        /// <param name="datastreamId">Datastream id</param>
        /// <param name="startDate">Start date</param>
        /// <param name="endDate">End date</param>
        /// <returns>Fetch result</returns>
        /// <exception cref="HttpRequestException">Unable to get data from Adverity Datatap API with method {Method.POST}. Url: {url}</exception>
        public string RunFetch(int datastreamId, DateTime startDate, DateTime endDate)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/datastreams/{datastreamId}/fetch_fixed/");

            RestClient client = new RestClient(url) { Timeout = -1 };
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Token {Token}");
            request.AddParameter("application/json", "{\"start\": \""+ startDate.ToString("yyyy-mm-ddTHH:MM:ssZ") + "\", \"end\": " + endDate.ToString("yyyy-mm-ddTHH:MM:ssZ") + "\"}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            else
                throw new HttpRequestException($"Unable to get data from Adverity Datatap API with method {Method.POST}. Url: {url}");
        }

        /// <summary>
        /// Gets data extracts list
        /// </summary>
        /// <param name="datastreamId">Datastream id</param>
        /// <returns>Data extracts list</returns>
        public List<Extract> GetExtractsList(int datastreamId)
        {
            List<Extract> result = new List<Extract>();

            DataPagesContainer<Extract> container = GetExtractsList(datastreamId, 1);
            result.AddRange(container.Results);

            while (container.NextPage != null)
            {
                container = GetDataFromApi<DataPagesContainer<Extract>>(container.NextPage);
                result.AddRange(container.Results);
            }

            return result;
        }

        /// <summary>
        /// Gets data extracts lists
        /// </summary>
        /// <param name="datastreamId">Datastream id</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Data extracts list</returns>
        public DataPagesContainer<Extract> GetExtractsList(int datastreamId, int pageNumber)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/extracts/?datastream_id={datastreamId}&page={pageNumber}");
            return GetDataFromApi<DataPagesContainer<Extract>>(url);
        }

        /// <summary>
        /// Gets all data extracts list
        /// </summary>
        /// <returns>Data extracts list</returns>
        public List<Extract> GetAllExtractsList()
        {
            List<Extract> result = new List<Extract>();

            DataPagesContainer<Extract> container = GetAllExtractsList(1);
            result.AddRange(container.Results);

            while (container.NextPage != null)
            {
                container = GetDataFromApi<DataPagesContainer<Extract>>(container.NextPage);
                result.AddRange(container.Results);
            }

            return result;
        }

        /// <summary>
        /// Gets all data extracts list
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Data extracts list</returns>
        public DataPagesContainer<Extract> GetAllExtractsList(int pageNumber)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/extracts/?page={pageNumber}");
            return GetDataFromApi<DataPagesContainer<Extract>>(url);
        }

        /// <summary>
        /// Get data extract in tsv format
        /// </summary>
        /// <param name="extractId">Data extract id</param>
        /// <returns>Extract data as tsv</returns>
        public string GetExtract(int extractId)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/extracts/{extractId}/download/");
            return GetDataFromApi(url);
        }

        /// <summary>
        /// Gets data collection errors/issues list
        /// </summary>
        /// <returns>List of errors/issues</returns>
        public List<DataCollectionError> GetDataCollectionErrorsList()
        {
            List<DataCollectionError> result = new List<DataCollectionError>();

            DataPagesContainer<DataCollectionError> container = GetDataCollectionErrorsList(1);
            result.AddRange(container.Results);

            while (container.NextPage != null)
            {
                container = GetDataFromApi<DataPagesContainer<DataCollectionError>>(container.NextPage);
                result.AddRange(container.Results);
            }

            return result;
        }

        /// <summary>
        /// Gets data collection errors/issues list
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <returns>List of errors/issues</returns>
        public DataPagesContainer<DataCollectionError> GetDataCollectionErrorsList(int pageNumber)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/errors/?page={pageNumber}");
            return GetDataFromApi<DataPagesContainer<DataCollectionError>>(url);
        }

        #endregion
    }
}
