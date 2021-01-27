FROM microsoft/dotnet:3.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:3.1-sdk AS build
WORKDIR /src
COPY . .
RUN dotnet restore SampleAPI.sln
WORKDIR /src/SampleAPI.Code
RUN dotnet build -c Release -o /app
FROM build as publish

RUN dotnet publish -c Release -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "SampleAPI.dll"]
