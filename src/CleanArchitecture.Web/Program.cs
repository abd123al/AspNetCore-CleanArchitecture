using CleanArchitecture.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

// START: Custom services
builder.Services.AddCustomizedRateLimit();
builder.Services.AddCustomizedMediatR();
builder.Services.AddCustomizedFluentValidation();
builder.Services.AddCustomizedAutoMapper();
builder.Services.AddCustomizedSwagger();
builder.Services.AddCustomizedRepository();
// END: Custom services

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCustomizedSwagger();
}

// START: Custom middlewares
app.UseCustomizedRateLimit();
app.UseCustomizedApi();
// END: Custom middlewares

// #pragma warning disable SA1649
app.Run();
