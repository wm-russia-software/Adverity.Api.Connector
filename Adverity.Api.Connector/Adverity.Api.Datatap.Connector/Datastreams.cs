using System.Collections.Generic;
using Adverity.Api.Datatap.Connector.Models;
using Ak.Framework.Core.Helpers;
using RestSharp;

namespace Adverity.Api.Datatap.Connector
{
    /// <summary>
    /// Datastreams handler
    /// </summary>
    public class Datastreams : BaseApiHandler
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Datastreams"/> class.
        /// </summary>
        /// <param name="apiUrl">API url</param>
        /// <param name="token">Token</param>
        public Datastreams(string apiUrl, string token) : base(apiUrl, token)
        {
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Gets datastream types list
        /// </summary>
        /// <returns>List of datastream types</returns>
        public List<DatastreamType> GetDatastreamTypesList()
        {
            List<DatastreamType> result = new List<DatastreamType>();

            DataPagesContainer<DatastreamType> container = GetDatastreamTypesList(1);
            result.AddRange(container.Results);

            while (container.NextPage != null)
            {
                container = GetDataFromApi<DataPagesContainer<DatastreamType>>(container.NextPage);
                result.AddRange(container.Results);
            }

            return result;
        }

        /// <summary>
        /// Gets datastream types list
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <returns>List of datastream types</returns>
        public DataPagesContainer<DatastreamType> GetDatastreamTypesList(int pageNumber)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/datastream-types/?page={pageNumber}");
            return GetDataFromApi<DataPagesContainer<DatastreamType>>(url);
        }

        /// <summary>
        /// Gets datastreams list
        /// </summary>
        /// <returns>List of datastreams</returns>
        public List<Datastream> GetDatastreamsList()
        {
            List<Datastream> result = new List<Datastream>();

            DataPagesContainer<Datastream> container = GetDatastreamsList(1);
            result.AddRange(container.Results);

            while (container.NextPage != null)
            {
                container = GetDataFromApi<DataPagesContainer<Datastream>>(container.NextPage);
                result.AddRange(container.Results);
            }

            return result;
        }

        /// <summary>
        /// Gets datastreams list
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <returns>List of datastreams</returns>
        public DataPagesContainer<Datastream> GetDatastreamsList(int pageNumber)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/datastreams/?page={pageNumber}");
            return GetDataFromApi<DataPagesContainer<Datastream>>(url);
        }

        /// <summary>
        /// Gets datastreams list by type
        /// </summary>
        /// <param name="dataStreamTypeId">Datastream type id</param>
        /// <returns>List of datastreams</returns>
        public List<Datastream> GetDatastreamsListByType(int dataStreamTypeId)
        {
            List<Datastream> result = new List<Datastream>();

            DataPagesContainer<Datastream> container = GetDatastreamsList(dataStreamTypeId, 1);
            result.AddRange(container.Results);

            while (container.NextPage != null)
            {
                container = GetDataFromApi<DataPagesContainer<Datastream>>(container.NextPage);
                result.AddRange(container.Results);
            }

            return result;
        }

        /// <summary>
        /// Gets datastreams list
        /// </summary>
        /// <param name="datastreamTypeId">Datastream type id</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>List of datastreams</returns>
        public DataPagesContainer<Datastream> GetDatastreamsList(int datastreamTypeId, int pageNumber)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/datastream-types/{datastreamTypeId}/datastreams/?page={pageNumber}");
            return GetDataFromApi<DataPagesContainer<Datastream>>(url);
        }

        /// <summary>
        /// Gets datastreams options
        /// </summary>
        /// <param name="dataStreamTypeId">Datastream type id</param>
        /// <returns>Datastream options</returns>
        public string GetDatastreamOptions(int dataStreamTypeId)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/datastream-types/{dataStreamTypeId}/datastreams/");
            return GetDataFromApi(url, Method.OPTIONS);
        }

        #endregion
    }
}
