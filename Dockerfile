# Starting from MS's dotnet image that has all the SDKs installed,
# build and unit test the app
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ENV ASPNETCORE_URLS=http://+:80 

COPY . /
WORKDIR /
RUN dotnet restore VemiMicroservice.sln

# Build
RUN dotnet build --configuration Release --no-restore VemiMicroservice.sln

# Create dotnet artifacts
RUN dotnet publish --no-restore -c Release --output /app VemiMicroservice.sln

# Build the deployment container. Switch base images from 'sdk' to
# 'runtime', and use Apline Linux, to reduce image size
FROM mcr.microsoft.com/dotnet/aspnet:9.0

# Set up the app to run
WORKDIR /app
COPY --from=build /app .
EXPOSE 5099

ENTRYPOINT ["dotnet", "VemiMicroservice.Api.dll"]
# ENTRYPOINT ["dotnet","DotNet.Docker.dll"]
# ENTRYPOINT ["./DotNet.Docker"]  

