#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["CleanArch.UI.Mvc/CleanArch.Mvc.csproj", "CleanArch.UI.Mvc/"]
COPY ["CleanArch.Infrastructure.IoC/CleanArch.Infrastructure.IoC.csproj", "CleanArch.Infrastructure.IoC/"]
COPY ["CleanArch.Infrastructure.Data/CleanArch.Infrastructure.Data.csproj", "CleanArch.Infrastructure.Data/"]
COPY ["CleanArch.Domain/CleanArch.Domain.csproj", "CleanArch.Domain/"]
COPY ["CleanArch.Domain.Core/CleanArch.Domain.Core.csproj", "CleanArch.Domain.Core/"]
COPY ["CleanArch.Application/CleanArch.Application.csproj", "CleanArch.Application/"]
COPY ["CleanArch.Infrastructure.Bus/CleanArch.Infrastructure.Bus.csproj", "CleanArch.Infrastructure.Bus/"]
RUN dotnet restore "CleanArch.UI.Mvc/CleanArch.Mvc.csproj"
COPY . .
WORKDIR "/src/CleanArch.UI.Mvc"
RUN dotnet build "CleanArch.Mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CleanArch.Mvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CleanArch.Mvc.dll"]
