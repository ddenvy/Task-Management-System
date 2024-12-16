# Task Management System

Это система управления задачами, построенная на микросервисной архитектуре с использованием gRPC и Docker.

## Сервисы
1. **User Service**: Управление пользователями.
2. **Task Service**: Управление задачами.
3. **Tracking Service**: Отслеживание статусов задач.
4. **Comment Service**: Управление комментариями к задачам.

## Локальные хосты
1. UserService: Now listening on: http://0.0.0.0:5004
2. TaskService: Now listening on: http://0.0.0.0:5002
3. TrackingService: Now listening on: http://0.0.0.0:5003
4. CommentService: Now listening on: http://0.0.0.0:5001



## Запуск
1. Сборка и запуск:
   docker-compose up --build

## Тесты:
 Установите Postman
•  Создайте новый gRPC запрос для каждого сервиса и подключите proto файл каждого сервиса
•  Настройки для всех запросов:
•  Server Reflection: off
•  SSL: off (Plaintext)
•  Используйте соответствующие порты для каждого сервиса


