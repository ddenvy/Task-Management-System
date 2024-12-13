# Используем базовый образ .NET 7
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5004

# Используем образ SDK для сборки
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Копируем файл проекта и восстанавливаем зависимости
COPY ["UserService.csproj", "./"]
RUN dotnet restore "./UserService.csproj"

# Копируем исходный код и собираем проект
COPY . .
WORKDIR "/src/."
RUN dotnet build "UserService.csproj" -c Release -o /app/build

# Публикуем проект
FROM build AS publish
RUN dotnet publish "UserService.csproj" -c Release -o /app/publish

# Используем базовый образ для запуска
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UserService.dll"]