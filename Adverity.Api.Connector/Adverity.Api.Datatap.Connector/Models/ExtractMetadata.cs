using Newtonsoft.Json;

namespace Adverity.Api.Datatap.Connector.Models
{
    /// <summary>
    /// Extracts metadata
    /// </summary>
    public class ExtractMetadata
    {
        #region Properties

        /// <summary>
        /// Pivots
        /// </summary>
        [JsonProperty("pivots")]
        public string[] Pivots { get; set; }

        /// <summary>
        /// Datastreams extract range end data
        /// </summary>
        [JsonProperty("datastream_extract_range_end")]
        public string DatastreamExtractRangeEnd { get; set; }

        /// <summary>
        /// Job id
        /// </summary>
        [JsonProperty("origin_job_id")]
        public int OriginJobId { get; set; }

        /// <summary>
        /// Datastreams extract range start data
        /// </summary>
        [JsonProperty("datastream_extract_range_start")]
        public string DatastreamExtractRangeStart { get; set; }

        /// <summary>
        /// Managed name
        /// </summary>
        [JsonProperty("managed_name")]
        public bool ManagedName { get; set; }

        /// <summary>
        /// Date of the extract
        /// </summary>
        [JsonProperty("extract_date")]
        public string ExtractDate { get; set; }

        #endregion
    }
}
