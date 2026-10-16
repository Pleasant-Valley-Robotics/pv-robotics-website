# Step 1: compile the site with the .NET SDK.
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
# Restore packages first, so this slow step is reused when only code changes.
COPY src/PvRobotics.Web/PvRobotics.Web.csproj src/PvRobotics.Web/
RUN dotnet restore src/PvRobotics.Web/PvRobotics.Web.csproj
COPY src/ src/
RUN dotnet publish src/PvRobotics.Web/PvRobotics.Web.csproj -c Release -o /app --no-restore

# Step 2: run it on the smaller ASP.NET runtime image. Only the compiled site is kept.
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app .
ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080
# Run as the image's ordinary "app" user, not root.
USER app
ENTRYPOINT ["dotnet", "PvRobotics.Web.dll"]
