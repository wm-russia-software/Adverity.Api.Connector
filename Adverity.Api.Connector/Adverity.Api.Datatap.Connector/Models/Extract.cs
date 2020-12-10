using System;
using Newtonsoft.Json;

namespace Adverity.Api.Datatap.Connector.Models
{
    /// <summary>
    /// Data extract
    /// </summary>
    public class Extract
    {
        #region Properties

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Creation date and time
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Datastream
        /// </summary>
        [JsonProperty("datastream")]
        public Datastream Datastream { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Date and time of scheduled run
        /// </summary>
        [JsonProperty("scheduled")]
        public DateTime Scheduled { get; set; }

        /// <summary>
        /// Rows quantity
        /// </summary>
        [JsonProperty("nrows", NullValueHandling = NullValueHandling.Ignore)]
        public int RowsQuantity { get; set; }

        /// <summary>
        /// Columns quantity
        /// </summary>
        [JsonProperty("ncols", NullValueHandling = NullValueHandling.Ignore)]
        public int ColumnsQuantity { get; set; }

        /// <summary>
        /// File size
        /// </summary>
        [JsonProperty("filesize", NullValueHandling = NullValueHandling.Ignore)]
        public int FileSize { get; set; }

        /// <summary>
        /// State
        /// </summary>
        [JsonProperty("state_label")]
        public string StateLabel { get; set; }

        /// <summary>
        /// State color
        /// </summary>
        [JsonProperty("state_color")]
        public string StateColor { get; set; }

        /// <summary>
        /// Url for extract preview
        /// </summary>
        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// Url for refetching action
        /// </summary>
        [JsonProperty("refetch_url")]
        public string RefetchUrl { get; set; }

        /// <summary>
        /// Url for requeue
        /// </summary>
        [JsonProperty("requeue_url")]
        public string RequeueUrl { get; set; }

        /// <summary>
        /// Url for extract download
        /// </summary>
        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public ExtractMetadata Metadata { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        /// <summary>
        /// Url for explore
        /// </summary>
        [JsonProperty("explore_url")]
        public object ExploreUrl { get; set; }

        /// <summary>
        /// Url for dashboard access
        /// </summary>
        [JsonProperty("dashboard_url")]
        public object DashboardUrl { get; set; }

        #endregion
    }
}
