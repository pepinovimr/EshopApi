using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using EshopApi.Services.Interfaces;
using EshopApi.Services;

namespace EshopApi.Filters
{
    [AttributeUsage(AttributeTargets.Method)]
    public class IdentityFilter : Attribute, IResourceFilter
    {

        public void OnResourceExecuted(ResourceExecutedContext context)
        {

        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            var _authorizationService = (IdentityService?)context.HttpContext.RequestServices.GetService(typeof(IIdentityService));

            if (_authorizationService is null)
            {
                context.Result = new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError
                };
                return;
            }

            _authorizationService.AuthorizeToken(context);

        }
    }
}
