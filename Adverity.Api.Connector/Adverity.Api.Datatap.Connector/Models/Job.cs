using System;
using Newtonsoft.Json;

namespace Adverity.Api.Datatap.Connector.Models
{
    /// <summary>
    /// Data gathering job
    /// </summary>
    public class Job
    {
        #region Properties

        /// <summary>
        /// Url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Date and time of job start
        /// </summary>
        [JsonProperty("job_start")]
        public DateTime JobStart { get; set; }

        /// <summary>
        /// Date and time of job end
        /// </summary>
        [JsonProperty("job_end")]
        public DateTime JobEnd { get; set; }

        /// <summary>
        /// Data extract range start date
        /// </summary>
        [JsonProperty("range_start")]
        public DateTime RangeStart { get; set; }

        /// <summary>
        /// Data extract range end date
        /// </summary>
        [JsonProperty("range_end")]
        public DateTime RangeEnd { get; set; }

        /// <summary>
        /// Date and time of scheduled run
        /// </summary>
        [JsonProperty("scheduled")]
        public DateTime Scheduled { get; set; }

        #endregion
    }
}
