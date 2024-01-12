# Use the official .NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /App
COPY ["2.csproj","."]
RUN dotnet restore
COPY . ./
RUN dotnet build -c Release -o out
FROM build-env AS publish
RUN dotnet publish -c Release -o /App/publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App
COPY --from=publish /App/publish .
ENTRYPOINT ["dotnet", "2.dll"]
