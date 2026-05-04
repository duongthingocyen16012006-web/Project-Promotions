FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/ngocyen.Web.Mvc/ngocyen.Web.Mvc.csproj", "src/ngocyen.Web.Mvc/"]
COPY ["src/ngocyen.Web.Core/ngocyen.Web.Core.csproj", "src/ngocyen.Web.Core/"]
COPY ["src/ngocyen.Application/ngocyen.Application.csproj", "src/ngocyen.Application/"]
COPY ["src/ngocyen.Core/ngocyen.Core.csproj", "src/ngocyen.Core/"]
COPY ["src/ngocyen.EntityFrameworkCore/ngocyen.EntityFrameworkCore.csproj", "src/ngocyen.EntityFrameworkCore/"]
WORKDIR "/src/src/ngocyen.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ngocyen.Web.Mvc", "src/ngocyen.Web.Mvc"]
COPY ["src/ngocyen.Web.Core", "src/ngocyen.Web.Core"]
COPY ["src/ngocyen.Application", "src/ngocyen.Application"]
COPY ["src/ngocyen.Core", "src/ngocyen.Core"]
COPY ["src/ngocyen.EntityFrameworkCore", "src/ngocyen.EntityFrameworkCore"]
WORKDIR "/src/src/ngocyen.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ngocyen.Web.Mvc.dll"]
