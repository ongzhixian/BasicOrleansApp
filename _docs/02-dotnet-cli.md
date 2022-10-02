# dotnet CLI

dotnet new globaljson
dotnet new sln -n BasicOrleansApp

dotnet new console -n BasicOrleansApp.HelloWorldApp
dotnet sln .\BasicOrleansApp.sln add .\BasicOrleansApp.HelloWorldApp\

dotnet new console -n BasicOrleansApp.BasicSiloApp
dotnet sln .\BasicOrleansApp.sln add .\BasicOrleansApp.BasicSiloApp\

dotnet new console -n BasicOrleansApp.BasicClientApp
dotnet sln .\BasicOrleansApp.sln add .\BasicOrleansApp.BasicClientApp\

dotnet new classlib -n BasicOrleansApp.BasicGrains
dotnet sln .\BasicOrleansApp.sln add .\BasicOrleansApp.BasicGrains\

dotnet new classlib -n BasicOrleansApp.BasicInterfaces
dotnet sln .\BasicOrleansApp.sln add .\BasicOrleansApp.BasicInterfaces\

## HelloWorldApp

dotnet add .\BasicOrleansApp.HelloWorldApp\ package Microsoft.Extensions.Hosting
dotnet add .\BasicOrleansApp.HelloWorldApp\ package Microsoft.Orleans.OrleansRuntime
dotnet add .\BasicOrleansApp.HelloWorldApp\ package Microsoft.Orleans.CodeGenerator.MSBuild

Reference: https://github.com/dotnet/orleans/tree/main/samples/HelloWorld


## BasicInterfaces

dotnet add .\BasicOrleansApp.BasicInterfaces\ package Microsoft.Orleans.Core.Abstractions

dotnet add .\BasicOrleansApp.BasicInterfaces\ package Microsoft.Orleans.CodeGenerator.MSBuild

## BasicGrains

dotnet add .\BasicOrleansApp.BasicGrains\ reference .\BasicOrleansApp.BasicInterfaces\
dotnet add .\BasicOrleansApp.BasicGrains\ package Microsoft.Extensions.Logging.Abstractions

dotnet add .\BasicOrleansApp.BasicGrains\ package Microsoft.Orleans.CodeGenerator.MSBuild

## BasicSiloApp

dotnet add .\BasicOrleansApp.BasicSiloApp\ package Microsoft.Extensions.Hosting
dotnet add .\BasicOrleansApp.BasicSiloApp\ package Microsoft.Orleans.Server
dotnet add .\BasicOrleansApp.BasicSiloApp\ package Microsoft.Extensions.Logging.Console
dotnet add .\BasicOrleansApp.BasicSiloApp\ reference .\BasicOrleansApp.BasicGrains\



## BasicClientApp

dotnet add .\BasicOrleansApp.BasicClientApp\ package Microsoft.Orleans.Client
dotnet add .\BasicOrleansApp.BasicClientApp\ package Microsoft.Extensions.Logging.Console
dotnet add .\BasicOrleansApp.BasicClientApp\ reference .\BasicOrleansApp.BasicInterfaces\

## Other notes

Microsoft.Extensions.DependencyInjection
Microsoft.Extensions.DependencyInjection.Abstractions

Microsoft.Orleans.OrleansRuntime
Microsoft.Orleans.CodeGenerator.MSBuild
Microsoft.Orleans.Core


Project 	        Nuget package
Silo 	            Microsoft.Orleans.Server
Silo 	            Microsoft.Extensions.Hosting
Silo 	            Microsoft.Extensions.Logging.Console

Client 	            Microsoft.Orleans.Client
Client 	            Microsoft.Extensions.Logging.Console

Grain Interfaces 	Microsoft.Orleans.Core.Abstractions
Grain Interfaces 	Microsoft.Orleans.CodeGenerator.MSBuild

Grains 	            Microsoft.Orleans.CodeGenerator.MSBuild
Grains 	            Microsoft.Orleans.Core.Abstractions
Grains 	            Microsoft.Extensions.Logging.Abstractions