using Newtonsoft.Json;

namespace Adverity.Api.Datatap.Connector.Models
{
    /// <summary>
    /// Datastream stack
    /// </summary>
    public class DatastreamStack
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
        /// Url for change action
        /// </summary>
        [JsonProperty("change_url")]
        public string ChangeUrl { get; set; }

        /// <summary>
        /// Url for accessing extracts
        /// </summary>
        [JsonProperty("extracts_url")]
        public string ExtractsUrl { get; set; }

        /// <summary>
        /// Url for accessing issues
        /// </summary>
        [JsonProperty("issues_url")]
        public string IssuesUrl { get; set; }

        /// <summary>
        /// Url for overview
        /// </summary>
        [JsonProperty("overview_url")]
        public string OverviewUrl { get; set; }

        /// <summary>
        /// Permissions
        /// </summary>
        [JsonProperty("permissions")]
        public DatastreamPermissions Permissions { get; set; }

        #endregion
    }
}
