
namespace MiddlewareCLass.MiddlewareComponent
{
    public class CustomMiddlewareException : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try 
            {
                context.Response.ContentType = "text/html";
                await next(context);
            }
            catch (Exception ex)
            {
                await context.Response.WriteAsync($"<h1> Error : </h> </br>");
                await context.Response.WriteAsync($"<p>{ex.Message} <p>");

            }
        }
    }
}
