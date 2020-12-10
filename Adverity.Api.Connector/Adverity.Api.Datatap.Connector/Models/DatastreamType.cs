using Newtonsoft.Json;

namespace Adverity.Api.Datatap.Connector.Models
{
    /// <summary>
    /// Datastream type
    /// </summary>
    public class DatastreamType
    {
        #region Properties

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Inner name
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Datastreams
        /// </summary>
        [JsonProperty("datastreams")]
        public string Datastreams { get; set; }

        /// <summary>
        /// Connection types
        /// </summary>
        [JsonProperty("connection_types")]
        public string[] ConnectionTypes { get; set; }

        /// <summary>
        /// Url for create action
        /// </summary>
        [JsonProperty("create_url")]
        public string CreateUrl { get; set; }

        /// <summary>
        /// Logo url
        /// </summary>
        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        #endregion
    }
}
