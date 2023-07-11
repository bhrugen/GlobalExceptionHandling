using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WhatsWrongAPI
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch
            {
                await HandleExceptionAsync(httpContext);
            }
        }

        private async Task HandleExceptionAsync(HttpContext httpContext)
        {
            httpContext.Response.ContentType = "application/problem+json";
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

            var pd = new ProblemDetails()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.1",
                Title = "An error occured while processing your request.",
                Status = StatusCodes.Status500InternalServerError,
            };
            var result = JsonConvert.SerializeObject(pd);
            await httpContext.Response.WriteAsync(result);
        }

    }
}
