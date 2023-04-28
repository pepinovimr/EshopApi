using EshopApi.Data.Model;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EshopApi.Services.Interfaces
{
    public interface IIdentityService
    {
        public ResourceExecutingContext AuthorizeToken(ResourceExecutingContext context);
    }
}
