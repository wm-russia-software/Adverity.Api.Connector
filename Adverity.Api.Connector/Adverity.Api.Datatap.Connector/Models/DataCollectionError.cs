using System;
using Newtonsoft.Json;

namespace Adverity.Api.Datatap.Connector.Models
{
    /// <summary>
    /// Data collection error
    /// </summary>
    public class DataCollectionError
    {
        #region Properties

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Start date of the extract which generated error
        /// </summary>
        [JsonProperty("start")]
        public DateTime Start { get; set; }

        /// <summary>
        /// End date of the extract which generated error
        /// </summary>
        [JsonProperty("end")]
        public DateTime End { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("type_label")]
        public string TypeLabel { get; set; }

        /// <summary>
        /// Datastream
        /// </summary>
        [JsonProperty("datastream")]
        public Datastream Datastream { get; set; }

        /// <summary>
        /// Extract
        /// </summary>
        [JsonProperty("extract")]
        public object Extract { get; set; }

        /// <summary>
        /// Is error acknowledged
        /// </summary>
        [JsonProperty("ack")]
        public bool Ack { get; set; }

        /// <summary>
        /// Url for acknowledgement action
        /// </summary>
        [JsonProperty("ack_url")]
        public string AckUrl { get; set; }

        /// <summary>
        /// Url for group acknowledgement action
        /// </summary>
        [JsonProperty("ack_group_url")]
        public string AckGroupUrl { get; set; }

        /// <summary>
        /// Url for retry action
        /// </summary>
        [JsonProperty("retry_url")]
        public string RetryUrl { get; set; }

        /// <summary>
        /// Url for group retry action
        /// </summary>
        [JsonProperty("retry_group_url")]
        public string RetryGroupUrl { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Data gathering job
        /// </summary>
        [JsonProperty("job")]
        public Job Job { get; set; }

        /// <summary>
        /// Url for mapping table change
        /// </summary>
        [JsonProperty("mapping_table_change_url")]
        public object MappingTableChangeUrl { get; set; }

        /// <summary>
        /// Url for mapping entries change
        /// </summary>
        [JsonProperty("mapping_entries_change_url")]
        public object MappingEntriesChangeUrl { get; set; }

        /// <summary>
        /// Url for target column change
        /// </summary>
        [JsonProperty("target_column_change_url")]
        public object TargetColumnChangeUrl { get; set; }

        /// <summary>
        /// Url for transformation config
        /// </summary>
        [JsonProperty("transformation_config_url")]
        public object TransformationConfigUrl { get; set; }

        /// <summary>
        /// Url for datastram insights
        /// </summary>
        [JsonProperty("datastream_insights_url")]
        public object DatastreamInsightsUrl { get; set; }

        /// <summary>
        /// Number of occurrences
        /// </summary>
        [JsonProperty("occurrences")]
        public int Occurrences { get; set; }

        #endregion
    }
}
