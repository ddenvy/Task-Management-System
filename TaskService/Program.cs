using TaskService.Services;

var builder = WebApplication.CreateBuilder(args);

// Добавление gRPC
builder.Services.AddGrpc();

var app = builder.Build();

// Настройка gRPC
app.MapGrpcService<TaskServiceImpl>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client.");

// Указываем порт для gRPC
app.Urls.Add("http://0.0.0.0:5002");

app.Run();