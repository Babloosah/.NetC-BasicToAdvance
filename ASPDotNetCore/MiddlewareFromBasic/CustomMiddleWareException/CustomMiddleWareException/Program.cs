using Microsoft.AspNetCore.Builder;
using MiddlewareCLass.MiddlewareComponent;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<CustomMiddlewareException>();
var app = builder.Build();

app.UseMiddleware<CustomMiddlewareException>();

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware 1 before call \r\n");
    await next(context);
    await context.Response.WriteAsync("Middleware 1 after call \r\n");
});


app.Use(async (HttpContext context, RequestDelegate next) =>
{
    throw new NotImplementedException("Not Implemented");
    //await context.Response.WriteAsync("Middleware 2 before call \r\n");
    //await next(context);
    //await context.Response.WriteAsync("Middleware 2 after call \r\n");
});

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware 3 before call \r\n");
    await next(context);
    await context.Response.WriteAsync("Middleware 3 after call \r\n");
});


app.Run();


app.Run();
