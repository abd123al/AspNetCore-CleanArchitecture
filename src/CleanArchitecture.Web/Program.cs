using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.UseCases;
using CleanArchitecture.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

// START: Custom services
builder.Services.AddCustomizedRateLimit();
builder.Services.AddCustomizedFluentValidation();
builder.Services.AddCustomizedAutoMapper();
builder.Services.AddCustomizedSwagger();
var connectionString = builder.Configuration.GetConnectionString("SQLiteConnection") ?? string.Empty;
builder.Services.AddApplicationDbContext(connectionString);
builder.Services.AddCustomizedRepository();
builder.Services.AddCustomizedMediatR();
builder.Services.AddCustomizedListService();
// END: Custom services

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCustomizedSwagger();
    app.UseCustomizedListService();
}

// START: Custom middlewares
app.UseCustomizedRateLimit();
app.UseCustomizedApi();
// END: Custom middlewares

// #pragma warning disable SA1649
app.Run();
