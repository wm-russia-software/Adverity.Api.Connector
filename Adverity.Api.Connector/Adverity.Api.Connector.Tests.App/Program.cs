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
            //string token = new Authentication(Settings.AdverityApiUrl).GetToken(yourUserName, yourPassword);
            
            List<Datastream> datastreams = new Datastreams(Settings.AdverityApiUrl, Settings.AdverityApiToken).GetDatastreamsList();

            Fetching fetchingApi = new Fetching(Settings.AdverityApiUrl, Settings.AdverityApiToken);
            List<Extract> extracts = fetchingApi.GetAllExtractsList();
            //string tsv = fetchingApi.GetExtract(extractId);
            List<DataCollectionError> errors = fetchingApi.GetDataCollectionErrorsList();

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
