FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Codeforces/Codeforces.csproj", "Codeforces/"]
RUN dotnet restore "Codeforces/Codeforces.csproj"
COPY . .
WORKDIR "/src/Codeforces"
RUN dotnet build "Codeforces.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Codeforces.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Codeforces.dll"]
