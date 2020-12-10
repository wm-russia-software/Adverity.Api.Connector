using Newtonsoft.Json;

namespace Adverity.Api.Datatap.Connector.Models
{
    /// <summary>
    /// Container for data with paging
    /// </summary>
    /// <typeparam name="T">Container data type</typeparam>
    public class DataPagesContainer<T>
    {
        #region Properties

        /// <summary>
        /// Number of elements
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Api request url for getting next page
        /// </summary>
        [JsonProperty("next")]
        public string NextPage { get; set; }

        /// <summary>
        /// Api request url for getting previous page
        /// </summary>
        [JsonProperty("previous")]
        public object PreviousPage { get; set; }

        /// <summary>
        /// Results
        /// </summary>
        [JsonProperty("results")]
        public T[] Results { get; set; }

        #endregion
    }
}
