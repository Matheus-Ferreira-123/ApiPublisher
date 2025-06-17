// Program.cs
using ApiPublisherApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<PedidoService>();
builder.Services.AddControllers();

var app = builder.Build();
app.UseAuthorization();
app.MapControllers();
app.Run();



