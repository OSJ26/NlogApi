using Nlog.BLL.Interface;
using Nlog.BLL.Servcie;
using Nlog.DAL.Interface;
using Nlog.DAL.Servcie;
using Nlog.PL.Interface;
using Nlog.PL.Service;
using NLog.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProGet, sCtsd01>();
builder.Services.AddScoped<ICtsBll, sCtsBll>();
builder.Services.AddScoped<ILog, SimpleLog>();

builder.Services.AddLogging(logging =>
{
    logging.ClearProviders();
    logging.SetMinimumLevel(LogLevel.Trace);
    logging.AddNLog();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
