using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Web_API_Pattern.Extensions;
using Web_API_Pattern.Resources;

namespace Web_API_Pattern.Controllers.Base
{
    public static class InvalidModelStateResponseFactory
    {
        public static IActionResult ProduceErrorResponse(ActionContext context)
        {
            var errors = context.ModelState.GetErrorMessages();
            var response = new ErrorResource(messages: errors);
            
            return new BadRequestObjectResult(response);
        }
    }
}