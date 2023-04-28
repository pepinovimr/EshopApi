using EshopApi.Data.DTOs;
using EshopApi.Data.Model;

namespace EshopApi.Services.Interfaces
{
    public interface IEshopItemsService
    {
        public List<PurchaseOrderHeaders> GetList();

        public PurchaseOrderResponseDTO AddPurchases(List<PurchaseOrderDTO> orderDTOs);
    }
}
