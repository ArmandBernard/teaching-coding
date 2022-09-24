# Purpose

To outline some stuff about .NET templates.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [Available templates](#available-templates)
- [Arguments](#arguments)
  - [Dry Run](#dry-run)
  - [Framework](#framework)
  - [Template specific options](#template-specific-options)
  - [Output directory](#output-directory)
  - [Name](#name)

# Available templates

The templates that are available can be seen [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new#arguments) or extracted from the command line using

```ps1
dotnet new --list
```

The output should look something like

```
Template Name                                 Short Name           Language    Tags
--------------------------------------------  -------------------  ----------  --------------------------
ASP.NET Core Empty                            web                  [C#],F#     Web/Empty
ASP.NET Core gRPC Service                     grpc                 [C#]        Web/gRPC
ASP.NET Core Web API                          webapi               [C#],F#     Web/WebAPI
ASP.NET Core Web App                          webapp,razor         [C#]        Web/MVC/Razor Pages
...
```

# Arguments

The cli format is available [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new#synopsis), the format is:

```ps1
dotnet new <TEMPLATE> [--dry-run] [--force] [-lang|--language {"C#"|"F#"|VB}]
    [-n|--name <OUTPUT_NAME>] [--no-update-check] [-o|--output <OUTPUT_DIRECTORY>] [Template options]

dotnet new -h|--help
```

Where `<TEMPLATE>` is the previously mentioned template short name available through `--list`.

C# seems to be the default language in most cases.

## Dry Run

`--dry-run` is especially useful as it will show you what the output will be without actually doing it.

```
File actions would have been taken:
  Create: ./Controllers/WeatherForecastController.cs
  Create: ./Properties/launchSettings.json
  Create: ./appsettings.Development.json
  Create: ./appsettings.json
  Create: ./WebApiTest.csproj
  Create: ./Program.cs
  Create: ./WeatherForecast.cs

Processing post-creation actions...
Action would have been taken automatically:
   Restore NuGet packages required by this project.
```

## Framework

You can pick your .NET Framework / Core version using `-f|--framework` e.g.

```ps1
dotnet new console --framework net5.0
```

## Template specific options

Using

```ps1
dotnet new console --help
```

Will tell you all the options you can set for a specific template.

## Output directory

Picking an output directory can be done with `-o|--output` e.g.

```ps1
dotnet new console --output <OUTPUT_DIRECTORY>
```

## Name

The name of the project will default to the name of the folder it is contained in.

The name of the project can be manually set with `-n|--name` e.g.

```ps1
dotnet new console --name MyProject
```
