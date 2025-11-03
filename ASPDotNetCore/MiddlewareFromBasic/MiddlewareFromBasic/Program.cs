var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Midllware 1 before call. \r\n");
    await next(context);

    await context.Response.WriteAsync("Midllware 1 after call. \r\n");
});

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Midllware 2 before call. \r\n");
    await next(context);
    await context.Response.WriteAsync("Midllware 2 after call. \r\n");
});

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Midllware 3 before call. \r\n");
    await next(context);
    await context.Response.WriteAsync("Midllware 3 after call. \r\n");
});

app.Run();
