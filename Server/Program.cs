var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSignalR();

var app = builder.Build();
app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapHub<MessageHub>("/chatHub");
app.MapControllers();
app.Run();