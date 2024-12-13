using Grpc.Core;
using TaskService;

namespace TaskService.Services
{
    public class TaskServiceImpl : TaskService.TaskServiceBase
    {
        public override Task<TaskResponse> CreateTask(CreateTaskRequest request, ServerCallContext context)
        {
            // Логика создания задачи
            return Task.FromResult(new TaskResponse
            {
                TaskId = Guid.NewGuid().ToString(),
                Title = request.Title,
                Description = request.Description,
                UserId = request.UserId
            });
        }

        public override Task<TaskResponse> GetTask(GetTaskRequest request, ServerCallContext context)
        {
            // Логика получения задачи
            return Task.FromResult(new TaskResponse
            {
                TaskId = request.TaskId,
                Title = "Task 1",
                Description = "Description",
                UserId = "1"
            });
        }
    }
}