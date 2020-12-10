using Newtonsoft.Json;

namespace Adverity.Api.Datatap.Connector.Models
{
    /// <summary>
    /// Datastream permissions
    /// </summary>
    public class DatastreamPermissions
    {
        #region Properties

        /// <summary>
        /// Is user manager of datastream
        /// </summary>
        [JsonProperty("isDatastreamManager")]
        public bool IsDatastreamManager { get; set; }

        #endregion
    }
}
