# Adverity.Api.Connector
This library provides functionality for connecting and using data gathering methods from Adverity Datatap API.\
[Adverity](https://www.adverity.com/) is a popular marketing data provider. Its product Adverity Datatap can automatically extract, transform and load data from a wide range of sources.

## Installation
Package is available at [nuget](https://www.nuget.org/packages/Adverity.Api.Datatap.Connector). You can either use your favorite package manager or run 

```bash
Install-Package Adverity.Api.Datatap.Connector -Version 1.0.5
```

## Usage

```c#
using Adverity.Api.Datatap.Connector;
using Adverity.Api.Datatap.Connector.Models;

...

// Obtaining authentification token. It can be stored for further usage in order not to get it every time.
string token = new Authentication(yourAdverityApiUrl).GetToken(yourUserName, yourPassword);

// Listing all datastreams
List<Datastream> datastreams = new Datastreams(yourAdverityApiUrl, token).GetDatastreamsList();

Fetching fetchingApi = new Fetching(Settings.AdverityApiUrl, Settings.AdverityApiToken);
// Getting list of all extracts in selected datastream
List<Extract> extracts = fetchingApi.GetAllExtractsList(datastreamId);
// Getting fetched data from extract in tsv format
string tsv = fetchingApi.GetExtract(extractId);

// Listing all errors/issues
List<DataCollectionError> errors = fetchingApi.GetDataCollectionErrorsList();

```

For more information about using Adverity.Api.Connector take a look at our [documentation](https://github.com/wm-russia-software/Adverity.Api.Connector/wiki).

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## Plans
Right now our library can be used only for data gathering operations and viewing issues. We are looking forward to expand it to other Api methods.

## License
[MIT](https://choosealicense.com/licenses/mit/)
