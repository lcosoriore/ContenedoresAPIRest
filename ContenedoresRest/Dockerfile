FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ContenedoresRest.csproj", ""]
COPY ["../Containers/Containers.csproj", "../Containers/"]
COPY ["../xUnit.ContenedoresRest/xUnit.ContenedoresRest.csproj", "../xUnit.ContenedoresRest/"]
COPY ["../ADO.Rest/ADO.Rest.csproj", "../ADO.Rest/"]
RUN dotnet restore "ContenedoresRest.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "ContenedoresRest.csproj" -c Release -o /app/build

FROM build AS publish
RUN apt-get update -yq \
    && apt-get install curl gnupg -yq \
    && curl -sL https://deb.nodesource.com/setup_14.x | bash \
    && apt-get install nodejs -yq
RUN dotnet publish "ContenedoresRest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContenedoresRest.dll"]
