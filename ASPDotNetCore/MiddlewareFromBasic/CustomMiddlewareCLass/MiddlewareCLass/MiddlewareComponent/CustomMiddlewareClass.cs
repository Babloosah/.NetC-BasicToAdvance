
namespace MiddlewareCLass.MiddlewareComponent
{
    public class CustomMiddlewareClass : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custom Middleware before call \r\n");
            await next(context);
            await context.Response.WriteAsync("Custom Middleware after call \r\n");
        }
    }
}
