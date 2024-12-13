# Используем базовый образ .NET 7
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5002

# Используем образ SDK для сборки
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Копируем файл проекта и восстанавливаем зависимости
COPY ["TaskService.csproj", "./"]
RUN dotnet restore "./TaskService.csproj"

# Копируем исходный код и собираем проект
COPY . .
WORKDIR "/src/."
RUN dotnet build "TaskService.csproj" -c Release -o /app/build

# Публикуем проект
FROM build AS publish
RUN dotnet publish "TaskService.csproj" -c Release -o /app/publish

# Используем базовый образ для запуска
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TaskService.dll"]