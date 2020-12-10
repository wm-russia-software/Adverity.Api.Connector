using System;
using System.Collections.Generic;
using Adverity.Api.Datatap.Connector;
using Adverity.Api.Datatap.Connector.Models;

namespace Adverity.Api.Connector.Tests.App
{
    /// <summary>
    /// Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        /// <param name="args">Arguments</param>
        private static void Main(string[] args)
        {
            Fetching api = new Fetching(Settings.AdverityApiUrl, Settings.AdverityApiToken);
            List<DataCollectionError> result = api.GetDataCollectionErrorsList();

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
