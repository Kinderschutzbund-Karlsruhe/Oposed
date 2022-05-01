using Microsoft.AspNetCore;
using Microsoft.OpenApi.Models;
using OposedApi.Attributes;
using OposedApi.Utilities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Oposed API", Version = "v1" });
    c.EnableAnnotations();
    c.OperationFilter<AuthFilter>();
});


//WebHost.CreateDefaultBuilder(args).UseUrls("http://localhost:5000");
    

var app = builder.Build();

MailSenderUtility.Init();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials



app.UseAuthorization();


app.MapControllers();

app.Run();