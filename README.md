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

2. Тесты:
1. Создание пользователя: grpcurl -plaintext -d '{"name": "John", "email": "john@example.com", "password": "123456"}' localhost:5004 user.UserService/CreateUser
2. Создание задачи: grpcurl -plaintext -d '{"title": "Task 1", "description": "Description", "user_id": "1"}' localhost:5002 task.TaskService/CreateTask
3. Получение статуса задачи: grpcurl -plaintext -d '{"task_id": "1"}' localhost:5003 tracking.TrackingService/GetTaskStatus
4. Добавление комментария: grpcurl -plaintext -d '{"task_id": "1", "user_id": "1", "text": "Comment 1"}' localhost:5001 comment.CommentService/AddComment
