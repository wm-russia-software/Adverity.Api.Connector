using System.Configuration;
using Ak.Framework.Core.Extensions;

namespace Adverity.Api.Connector.Tests.App
{
    /// <summary>
    /// Settings
    /// </summary>
    internal class Settings
    {
        #region Properties

        /// <summary>
        /// Adverity API Url
        /// </summary>
        public static string AdverityApiUrl => ConfigurationManager.AppSettings["AdverityApiUrl"].ToStr();

        /// <summary>
        /// Adverity API Token
        /// </summary>
        public static string AdverityApiToken => ConfigurationManager.AppSettings["AdverityApiToken"].ToStr();

        /// <summary>
        /// Adverity API user name
        /// </summary>
        public static string AdverityApiUserName => ConfigurationManager.AppSettings["AdverityApiUserName"].ToStr();

        /// <summary>
        /// Adverity API user password
        /// </summary>
        public static string AdverityApiUserPassword => ConfigurationManager.AppSettings["AdverityApiUserPassword"].ToStr();

        #endregion
    }
}
