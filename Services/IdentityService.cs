using EshopApi.Data;
using EshopApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EshopApi.Services
{
    public class IdentityService : IIdentityService
    {
        private ApplicationDbContext _context;

        public IdentityService(ApplicationDbContext context)
        {
            _context = context;
        }
        public ResourceExecutingContext AuthorizeToken(ResourceExecutingContext context)
        {
            var security_Id = context.HttpContext.Request.Headers.Where(x => x.Key == "Security-Identifier").FirstOrDefault();

            if (_context is null)
            {
                context.Result = new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError
                };
                return context;
            }

            var token = _context.CompanyKeys.FirstOrDefault(x => x.CompanyHash.Equals(security_Id.Value));

            if (token is null)
            {
                context.Result = new UnauthorizedResult();
            }

            return context;
        }
    }
}
