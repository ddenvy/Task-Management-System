using UserService.Services;

var builder = WebApplication.CreateBuilder(args);

// Добавление gRPC
builder.Services.AddGrpc();

var app = builder.Build();

// Настройка gRPC
app.MapGrpcService<UserServiceImpl>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client.");


// Указываем порт для gRPC
app.Urls.Add("http://0.0.0.0:5004");

app.Run();