using ProfessoresApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDependencyInjection();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(
          config => config.AddPolicy("DefaultPolicy", builder =>
          {
              builder.AllowAnyOrigin() //qualquer dominio poder� acessar a API
                     .AllowAnyMethod() //permitir POST, PUT, DELETE, GET
                     .AllowAnyHeader(); //aceitar parametros de cabe�alho de requisi��o
          })
          );

var app = builder.Build();


    app.UseSwagger();
    app.UseSwaggerUI();


app.UseAuthorization();

app.UseCors("DefaultPolicy");

app.MapControllers();

app.Run();

public partial class Program { }
