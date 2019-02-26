FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY gremlinrunner/*.csproj ./gremlinrunner/
RUN dotnet restore

# copy everything else and build app
COPY gremlinrunner/. ./gremlinrunner/
WORKDIR /app/gremlinrunner
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/gremlinrunner/out ./
ENTRYPOINT ["dotnet", "gremlinrunner.dll"]
