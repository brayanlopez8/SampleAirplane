FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["VuelosApp/VuelosApp.csproj", "VuelosApp/"]
RUN dotnet restore "VuelosApp/VuelosApp.csproj"
COPY . .
WORKDIR "/src/VuelosApp"
RUN dotnet build "VuelosApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "VuelosApp.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VuelosApp.dll"]