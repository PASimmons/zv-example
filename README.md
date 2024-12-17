# VemiMicroService

This project is intended as a basic microservice with all the functionality required by Vemi Money

It was generated using the [CQRS Microservice Template](https://github.com/thirschel/dotnet-cqrs-microservice-template)!

## Features of this project:

* CQRS (/)
* Example domain object (/)
* Health ??  (?)
* Dapr (TBA)
* Patterns - Tiny Values, Connect Adapter (TBA)


## Setting up development environment 🛠

### 1. Add a config file

### 2. Build the solution

> You can also use Visual Studio or VS Code to build and run the solution.

|||||
|-|-|-|-|
|Windows| .Net Core | > ```dotnet build VemiMicroservice.sln``` |
|| Docker | > ```docker build -t VemiMicroService .``` |

## 3. Run the solution

### Locally:
dotnet build
dotnet run --project src/VemiMicroservice.Api

### In docker:
docker build -t vemi-microservice .
docker run -p 5099:5099 vemi-microservice


## 4. Try it out!

[http://localhost:5099/swagger](http://localhost:5099/swagger)

## Appendix: How to recreate from template
Steps to re-use the template are as follows, there may be easier ways to do this in dotnet:

1. Clone the template repo ```git clone https://github.com/thirschel/dotnet-cqrs-microservice-template.git```
2. Grab and install a dotnet template (called cqrs-ms) from this repo: ```dotnet new install dotnet-cqrs-microservice-template```
3. Generate a project from this template, eg: ```dotnet new cqrs-ms --projectName VemiMicroservice --repoName VemiMicroService --output VemiMicroservice ```


