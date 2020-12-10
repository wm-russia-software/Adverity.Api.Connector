using System;
using Newtonsoft.Json;

namespace Adverity.Api.Datatap.Connector.Models
{
    /// <summary>
    /// Datastream
    /// </summary>
    public class Datastream
    {
        #region Properties

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Stack
        /// </summary>
        [JsonProperty("stack")]
        public DatastreamStack Stack { get; set; }

        /// <summary>
        /// Stack id
        /// </summary>
        [JsonProperty("stack_id")]
        public int StackId { get; set; }

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
        /// Application label
        /// </summary>
        [JsonProperty("app_label")]
        public string AppLabel { get; set; }

        /// <summary>
        /// Absolute Url
        /// </summary>
        [JsonProperty("absolute_url")]
        public string AbsoluteUrl { get; set; }

        /// <summary>
        /// Url for changing action
        /// </summary>
        [JsonProperty("change_url")]
        public string ChangeUrl { get; set; }

        /// <summary>
        /// Url for extracts
        /// </summary>
        [JsonProperty("extracts_url")]
        public string ExtractsUrl { get; set; }

        /// <summary>
        /// Url for fetch action
        /// </summary>
        [JsonProperty("fetch_url")]
        public string FetchUrl { get; set; }

        /// <summary>
        /// Url for overview
        /// </summary>
        [JsonProperty("overview_url")]
        public string OverviewUrl { get; set; }

        /// <summary>
        /// Is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Date nad time for the next run
        /// </summary>
        [JsonProperty("next_run")]
        public string NextRunDateTime { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Datastream type id
        /// </summary>
        [JsonProperty("datastream_type_id")]
        public int DatastreamTypeId { get; set; }

        /// <summary>
        /// Logo url
        /// </summary>
        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Url for extracts stream
        /// </summary>
        [JsonProperty("extracts_stream_url")]
        public string ExtractsStreamUrl { get; set; }

        /// <summary>
        /// Is extended intervals supported
        /// </summary>
        [JsonProperty("supports_extended_intervals")]
        public bool SupportsExtendedIntervals { get; set; }

        /// <summary>
        /// Date and time of last update
        /// </summary>
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Creator username
        /// </summary>
        [JsonProperty("creator")]
        public string Creator { get; set; }

        #endregion
    }
}
