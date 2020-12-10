using System.Collections.Generic;
using Adverity.Api.Datatap.Connector.Models;
using Ak.Framework.Core.Helpers;
using RestSharp;

namespace Adverity.Api.Datatap.Connector
{
    /// <summary>
    /// Connections handler
    /// </summary>
    public class Connections : BaseApiHandler
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Connections"/> class.
        /// </summary>
        /// <param name="apiUrl">API url</param>
        /// <param name="token">Token</param>
        public Connections(string apiUrl, string token) : base(apiUrl, token)
        {
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Gets connection types list
        /// </summary>
        /// <returns></returns>
        public List<ConnectionType> GetConnectionTypesList()
        {
            List<ConnectionType> result = new List<ConnectionType>();

            DataPagesContainer<ConnectionType> container = GetConnectionTypesList(1);
            result.AddRange(container.Results);

            while (container.NextPage != null)
            {
                container = GetDataFromApi<DataPagesContainer<ConnectionType>>(container.NextPage);
                result.AddRange(container.Results);
            }

            return result;
        }

        /// <summary>
        /// Gets connection types list
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <returns></returns>
        public DataPagesContainer<ConnectionType> GetConnectionTypesList(int pageNumber)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/connection-types/?page={pageNumber}");
            return GetDataFromApi<DataPagesContainer<ConnectionType>>(url);
        }

        /// <summary>
        /// Gets connections list
        /// </summary>
        /// <param name="connectionTypeId">Connection type id</param>
        /// <returns></returns>
        public List<Connection> GetConnectionsList(int connectionTypeId)
        {
            List<Connection> result = new List<Connection>();

            DataPagesContainer<Connection> container = GetConnectionsList(connectionTypeId, 1);
            result.AddRange(container.Results);

            while (container.NextPage != null)
            {
                container = GetDataFromApi<DataPagesContainer<Connection>>(container.NextPage);
                result.AddRange(container.Results);
            }

            return result;
        }

        /// <summary>
        /// Gets connections list
        /// </summary>
        /// <param name="connectionTypeId">Connection type id</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns></returns>
        public DataPagesContainer<Connection> GetConnectionsList(int connectionTypeId, int pageNumber)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/connection-types/{connectionTypeId}/connections/?page={pageNumber}");
            return GetDataFromApi<DataPagesContainer<Connection>>(url);
        }

        /// <summary>
        /// Gets connection options
        /// </summary>
        /// <param name="connectionTypeId">Connection type id</param>
        /// <returns></returns>
        public string GetConnectionOptions(int connectionTypeId)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/connection-types/{connectionTypeId}/connections/");
            return GetDataFromApi(url, Method.OPTIONS);
        }

        #endregion
    }
}
