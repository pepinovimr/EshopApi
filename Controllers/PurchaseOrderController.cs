using EshopApi.Data.DTOs;
using EshopApi.Filters;
using EshopApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EshopApi.Controllers
{
    [ApiController]
    [Route("Eshop")]
    public class PurchaseOrderController : Controller
    {
        public IEshopItemsService _eshopItemsService;

        public PurchaseOrderController(IEshopItemsService eshopItemsService)
        {
            _eshopItemsService = eshopItemsService;
        }

        [HttpGet]
        [Route("List")]
        public IActionResult GetList()
        {
            return new JsonResult(_eshopItemsService.GetList());
        }

        [IdentityFilter]
        [HttpPost]
        [Route("Add")]
        public IActionResult PostItems(List<PurchaseOrderDTO> purchaseDTOs)
        {
            return new JsonResult(_eshopItemsService.AddPurchases(purchaseDTOs));
        }
    }
}
