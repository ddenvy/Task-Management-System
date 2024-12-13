using Grpc.Core;
using UserService;

namespace UserService.Services
{
    public class UserServiceImpl : UserService.UserServiceBase
    {
        public override Task<UserResponse> CreateUser(CreateUserRequest request, ServerCallContext context)
        {
            // Логика создания пользователя
            return Task.FromResult(new UserResponse
            {
                UserId = Guid.NewGuid().ToString(),
                Name = request.Name,
                Email = request.Email
            });
        }

        public override Task<UserResponse> GetUser(GetUserRequest request, ServerCallContext context)
        {
            // Логика получения пользователя
            return Task.FromResult(new UserResponse
            {
                UserId = request.UserId,
                Name = "John",
                Email = "john@example.com"
            });
        }
    }
}