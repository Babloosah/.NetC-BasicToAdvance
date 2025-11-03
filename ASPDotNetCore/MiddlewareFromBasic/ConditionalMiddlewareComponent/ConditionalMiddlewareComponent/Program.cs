using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware 1 before call \r\n");
    await next(context);
    await context.Response.WriteAsync("Middleware 1 after call \r\n");
});

// another way to handle branching is app.MapWhen(). 

app.UseWhen((HttpContext context) =>
{
    return context.Request.Path.StartsWithSegments("/employee")
    && context.Request.Query.ContainsKey("Id");
}
    , (appBuilder) =>
    {
        appBuilder.Use(async (HttpContext context, RequestDelegate next) =>
        {
            await context.Response.WriteAsync("Middleware 4 before call \r\n");
            await next(context);
            await context.Response.WriteAsync("Middleware 4 after call \r\n");
        });

        appBuilder.Use(async (HttpContext context, RequestDelegate next) =>
        {
            await context.Response.WriteAsync("Middleware 5 before call \r\n");
            await next(context);
            await context.Response.WriteAsync("Middleware 5 after call \r\n");
        });

    }
);

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware 2 before call \r\n");
    await next(context);
    await context.Response.WriteAsync("Middleware 2 after call \r\n");
});
    
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware 3 before call \r\n");
    await next(context);
    await context.Response.WriteAsync("Middleware 3 after call \r\n");
});


app.Run();
