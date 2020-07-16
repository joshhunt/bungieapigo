# GhostSharper - Bungie API C# classes

This project implements C# classes for the [Bungie.net API](https://github.com/Bungie-net/api). While it does provide class definitions for API responses, it does not provide API helpers to call the API itself - that's up to you. The code is completely generated from Bungie's documentation - I previously the OpenAPI codegen tool, but found the generated code to be too messy so I opted for a custom generator so we could make the result as nice as possible.

## Install

Published to Nuget as [`GhostSharper`](https://www.nuget.org/packages/GhostSharper).

## Interfaces and Enums

There are definitions for every type defined in the Bungie.net services. See [their documentation](https://bungie-net.github.io/multi/) for a list - the interface names are the last part of the full name (for example, `Destiny.Definitions.DestinyVendorActionDefinition` becomes `DestinyVendorActionDefinition`).

## Usage

All definitions, enums, and API responses are on the `GhostSharper.Models` namespace. Additionally, `GhostSharper.Api.DestinyServerResponse` (name pending change) is a generic type used for API responses. e.g.

```csharp
using GhostSharper.Api;
using GhostSharper.Models;

var jsonString = await getHttpAsync("https://www.bungie.net/Platform/Destiny2/Manifest");
var manifestResponse = JsonConvert.DeserializeObject<DestinyServerResponse<DestinyManifest>>(response.Content);
Debug.WriteLine(manifestResponse.Response.Version)
```

## Updates

This repo and the published package is automatically updated using Github Actions when the API spec in the [Bungie.net API repo](https://github.com/Bungie-net/api) is update. The package version number published to NuGet matches the version from the Bungie API spec.

## Build

Node and Yarn is required for the generator. Node 14.x has been tested.

```
yarn --cwd ./generator install
yarn --cwd ./generator start
dotnet pack -nowarn:CS0659 -nowarn:CS0472 --include-symbols --include-source -c Release
```
