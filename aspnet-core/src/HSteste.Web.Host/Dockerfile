FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/HSteste.Web.Host/HSteste.Web.Host.csproj", "src/HSteste.Web.Host/"]
COPY ["src/HSteste.Web.Core/HSteste.Web.Core.csproj", "src/HSteste.Web.Core/"]
COPY ["src/HSteste.Application/HSteste.Application.csproj", "src/HSteste.Application/"]
COPY ["src/HSteste.Core/HSteste.Core.csproj", "src/HSteste.Core/"]
COPY ["src/HSteste.EntityFrameworkCore/HSteste.EntityFrameworkCore.csproj", "src/HSteste.EntityFrameworkCore/"]
WORKDIR "/src/src/HSteste.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/HSteste.Web.Host", "src/HSteste.Web.Host"]
COPY ["src/HSteste.Web.Core", "src/HSteste.Web.Core"]
COPY ["src/HSteste.Application", "src/HSteste.Application"]
COPY ["src/HSteste.Core", "src/HSteste.Core"]
COPY ["src/HSteste.EntityFrameworkCore", "src/HSteste.EntityFrameworkCore"]
WORKDIR "/src/src/HSteste.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "HSteste.Web.Host.dll"]
