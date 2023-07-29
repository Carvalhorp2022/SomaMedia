FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SomaMedia/SomaMedia.csproj", "SomaMedia/"]
RUN dotnet restore "SomaMedia/SomaMedia.csproj"
COPY . .
WORKDIR "/src/SomaMedia"
RUN dotnet build "SomaMedia.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SomaMedia.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SomaMedia.dll"]
