using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;



namespace Business.CustomException
{
    public class CustomExceptionFilter : IAsyncExceptionFilter
    {
        public Task OnExceptionAsync(ExceptionContext context)
        {
            

            context.ExceptionHandled = true;
            context.HttpContext.Response.StatusCode = 500; 
            context.Result = new JsonResult(new { error = "An error occurred" });

            return Task.CompletedTask;
        }
    }
}