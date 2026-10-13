# ExpressBot.Core

A standalone .NET 8 library of JSON models, BotXApi/BotApi interfaces, and an
HMAC-SHA256 signature helper for the [eXpress enterprise messenger](https://express.ms/).
Use it when implementing your own client or HTTP host.

[NuGet package](https://www.nuget.org/packages/ExpressBot.Core) ·
[Source code](https://github.com/vadarganiv/ExpressBot.Core) ·
[Issues](https://github.com/vadarganiv/ExpressBot.Core/issues) ·
[MIT license](https://github.com/vadarganiv/ExpressBot.Core/blob/main/LICENSE)

## Installation

```sh
dotnet add package ExpressBot.Core --version 0.1.1
```

The package targets .NET 8 and has no third-party NuGet dependencies.

## What is included

- Models with `System.Text.Json` property mappings for commands, callbacks,
  notifications, chats, users, and API responses.
- `IBotXApi` and `IBotApi` interfaces for custom implementations.
- `SignatureHelper.CreateHmacSha256Signature(data, key)` for generating an
  HMAC-SHA256 signature as uppercase hexadecimal text.

It does not provide an HTTP client, HTTP listener, or complete bot application.
The API is early-stage and retains its existing spelling, including
`DirectNotifycation` and `StatusResponce`.

## Example

Deserialize a version response into a model:

```csharp
using System.Text.Json;
using ExpressBot.Core.Models;

var version = JsonSerializer.Deserialize<BotXVersion>("""
    { "version": "1.0" }
    """);

Console.WriteLine(version?.Version);
```

For signatures, obtain the bot ID and secret from your environment or secret manager
and pass them to `SignatureHelper.CreateHmacSha256Signature`. Keep both the secret
and resulting authentication signature out of source control and logs.

## Relationship to ExpressBot

The separate [ExpressBot package](https://www.nuget.org/packages/ExpressBot) currently
embeds its own `ExpressBot.Core.*` types and does not reference this package.
The two sets of models are not interchangeable. Installing both packages in one
consumer can cause duplicate-type ambiguity. Use this package for a custom
implementation, or use ExpressBot alone for its provided client and listener.

## Changes in 0.1.1

- Added an embedded NuGet README, project/source links, and package tags.
- Clarified the package scope and usage examples.
- Public API is unchanged from 0.1.0; this is a documentation and packaging update.

## Build and contribute

```sh
dotnet build ExpressBot.Core.csproj -c Release
```

Report issues and propose changes in the
[GitHub repository](https://github.com/vadarganiv/ExpressBot.Core).
Released under the MIT license.
