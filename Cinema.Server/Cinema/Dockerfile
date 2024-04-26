FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

EXPOSE 8080

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore "Cinema.Server/Cinema/Cinema.csproj"
# Build and publish a release
RUN dotnet publish "Cinema.Server/Cinema/Cinema.csproj" -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Cinema.dll"]