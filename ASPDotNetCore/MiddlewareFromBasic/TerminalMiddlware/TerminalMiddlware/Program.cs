var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Short circuting middleware can be done by using terminal middleware. It break the flow of normal execution.
/* 
    1. this can be obtained by commenting out next() delegate from required middleware component. Comment line number 21.
    craeting middleware with app.run() always creates terminal middleware.
    
 */

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware 1 before call \r\n");
    await next(context);
    await context.Response.WriteAsync("Middleware 1 after call \r\n");
});

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware 2 before call \r\n");
    await next(context);
    await context.Response.WriteAsync("Middleware 2 after call \r\n");
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Terminal Middleware2 before call \r\n");
});


app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware 3 before call \r\n");
    await next(context);
    await context.Response.WriteAsync("Middleware 3 after call \r\n");
});

app.Run();
