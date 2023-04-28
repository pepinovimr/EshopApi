using EshopApi.Data;
using EshopApi.Data.DTOs;
using EshopApi.Data.Mappers;
using EshopApi.Data.Model;
using EshopApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace EshopApi.Services
{
    public class EshopItemsService : IEshopItemsService
    {
        private ApplicationDbContext _context;
        public EshopItemsService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets list of all purchases from Database
        /// </summary>
        public List<PurchaseOrderHeaders> GetList()
        {
            var result = _context.PurchaseOrderHeaders
                                            .Include(b => b.PurchaseOrderItems)
                                            .ToList();
            return result;
        }

        public PurchaseOrderResponseDTO AddPurchases(List<PurchaseOrderDTO> orderDTOs)
        {
            var response = new PurchaseOrderResponseDTO();

            foreach (var orderDTO in orderDTOs) 
            {
                if (!_context.PurchaseOrderHeaders.Any(x => x.PoNumber.Equals(orderDTO.poid)))
                {
                    var item = orderDTO.MapToPurchaseOrderItems();
                    _context.PurchaseOrderHeaders.Add(item);
                    _context.SaveChanges();

                    response.IdPairs.Add(item.MapToPurchaseIdPairDTO());
                    response.Succeded++;
                }
                else
                {
                    response.Failed++;
                }
            }

            return response;
        }
    }
}
