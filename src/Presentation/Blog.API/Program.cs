using Blog.Application;
using Blog.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Services
builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();
#endregion

builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.WithOrigins("https://localhost:7027", "http://localhost:5044").AllowAnyHeader().AllowAnyMethod().AllowCredentials()));

builder.Services.AddControllers();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
