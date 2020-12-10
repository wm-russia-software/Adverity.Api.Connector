using Newtonsoft.Json;

namespace Adverity.Api.Datatap.Connector.Models
{
    /// <summary>
    /// Connection
    /// </summary>
    public class Connection
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
        /// Is agency account 
        /// </summary>
        [JsonProperty("is_agency")]
        public bool IsAgency { get; set; }

        /// <summary>
        /// Client login
        /// </summary>
        [JsonProperty("client_login")]
        public string ClientLogin { get; set; }

        /// <summary>
        /// Stack
        /// </summary>
        [JsonProperty("stack")]
        public int Stack { get; set; }

        /// <summary>
        /// Application id
        /// </summary>
        [JsonProperty("app")]
        public int App { get; set; }

        #endregion
    }
}
