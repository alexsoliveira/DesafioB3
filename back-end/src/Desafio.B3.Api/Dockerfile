FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["./Desafio.B3.Api/Desafio.B3.Api.csproj", "src/Desafio.B3.Api/"]
RUN dotnet restore "src/Desafio.B3.Api/Desafio.B3.Api.csproj"
COPY . .
WORKDIR "/src/Desafio.B3.Api"
RUN dotnet build "./Desafio.B3.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build


FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Desafio.B3.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Desafio.B3.Api.dll"]