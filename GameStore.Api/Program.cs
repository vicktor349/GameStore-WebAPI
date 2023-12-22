using GameStore.Api.Data;
using GameStore.Api.Endpoints;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRepositories(builder.Configuration);


builder.Services.AddCors(Options => Options.AddPolicy("localhost:3000",
    builder => builder.WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .WithMethods("GET", "POST", "PUT", "DELETE")
));

var app = builder.Build();
app.Services.InitializeDb();

app.UseCors("localhost:3000");


app.MapGamesEndpoints();
app.Run();