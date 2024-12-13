using Grpc.Core;
using TrackingService;

namespace TrackingService.Services
{
    public class TrackingServiceImpl : TrackingService.TrackingServiceBase
    {
        public override Task<UpdateTaskStatusResponse> UpdateTaskStatus(UpdateTaskStatusRequest request, ServerCallContext context)
        {
            // Логика обновления статуса задачи
            return Task.FromResult(new UpdateTaskStatusResponse
            {
                Success = true
            });
        }

        public override Task<GetTaskStatusResponse> GetTaskStatus(GetTaskStatusRequest request, ServerCallContext context)
        {
            // Логика получения статуса задачи
            return Task.FromResult(new GetTaskStatusResponse
            {
                TaskId = request.TaskId,
                Status = "In Progress"
            });
        }
    }
}