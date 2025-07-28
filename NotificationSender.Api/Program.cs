using NotificationSender.Api.Interfaces;
using NotificationSender.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Notification Services
builder.Services.AddScoped<INotificationStrategy, EmailNotificationStrategy>(); // Default
builder.Services.AddScoped<EmailNotificationStrategy>();
builder.Services.AddScoped<SmsNotificationStrategy>();
builder.Services.AddScoped<NotificationContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
