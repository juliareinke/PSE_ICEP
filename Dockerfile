FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
RUN apt-get update \
    && apt-get install -y --no-install-recommends locales \
    && sed -i 's/# pt_BR.UTF-8 UTF-8/pt_BR.UTF-8 UTF-8/' /etc/locale.gen \
    && locale-gen
ENV LANG=pt_BR.UTF-8

COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
RUN apt-get update \
    && apt-get install -y --no-install-recommends locales \
    && sed -i 's/# pt_BR.UTF-8 UTF-8/pt_BR.UTF-8 UTF-8/' /etc/locale.gen \
    && locale-gen
ENV LANG=pt_BR.UTF-8

COPY --from=build /app/publish .
EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "PSE_ICEP.dll"]
