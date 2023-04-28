using EshopApi.Data.DTOs;
using EshopApi.Data.Model;

namespace EshopApi.Data.Mappers
{
    /// <summary>
    /// Enables mapping from PurchaseOrderResponseDTO to PurchaseOrderItems
    /// </summary>
    public static class PurchaseMapperExtension
    {
        /// <summary>
        /// Maps this to PurchaseOrderResponse
        /// </summary>
        /// <param name="purchaseOrderResponseDTO">DTO to map</param>
        public static PurchaseOrderHeaders MapToPurchaseOrderItems(this PurchaseOrderDTO purchaseOrderResponseDTO)
        {
            var itemsList = new List<PurchaseOrderItems>();
            var splt = purchaseOrderResponseDTO.createdon.Split('/');

            PurchaseOrderItems item = new PurchaseOrderItems()
            {
                Amount = purchaseOrderResponseDTO.amount,
                PricePerUnit = purchaseOrderResponseDTO.price,
                ShopItemTitle = purchaseOrderResponseDTO.item
            };
            itemsList.Add(item);

            PurchaseOrderHeaders header = new PurchaseOrderHeaders()
            {
                CustomerName = purchaseOrderResponseDTO.first_name,
                CustomerLastName = purchaseOrderResponseDTO.last_name,
                CustomerEmail = purchaseOrderResponseDTO.email,
                CreatedOn = new DateTime(int.Parse(splt[2]), int.Parse(splt[0]), int.Parse(splt[1])),
                PoNumber = purchaseOrderResponseDTO.poid,
                PurchaseOrderItems = itemsList
            };


            return header;
        }

        /// <summary>
        /// Maps this to list of PurchaseOrderResponse
        /// </summary>
        public static List<PurchaseOrderHeaders> MapToPurchaseOrderItemsList(this List<PurchaseOrderDTO> purchaseOrderResponseDTOs)
        {
            List<PurchaseOrderHeaders> newItems = new();

            foreach (var response in purchaseOrderResponseDTOs)
            {
                newItems.Add(response.MapToPurchaseOrderItems());
            }

            return newItems;
        }

        /// <summary>
        /// Maps this to PurchaseIdPairDTO
        /// </summary>
        public static PurchaseIdPairDTO MapToPurchaseIdPairDTO(this PurchaseOrderHeaders purchase)
        {
            List<int> poIds = new();
            foreach (var item in purchase.PurchaseOrderItems)
            {
                poIds.Add(item.PurchaserOrderId);
            }

            var output = new PurchaseIdPairDTO()
            {
                Id = purchase.PoNumber,
                PoId = poIds
            };

            return output;
        }

        /// <summary>
        /// Maps this to list of PurchaseIdPairDTO
        /// </summary>
        public static List<PurchaseIdPairDTO> MapToPurchaseIdPairDTOs(this List<PurchaseOrderHeaders> purchases)
        {
            List<PurchaseIdPairDTO> newItems = new();

            foreach (var purchase in purchases)
            {
                newItems.Add(purchase.MapToPurchaseIdPairDTO());
            }

            return newItems;
        }
    }
}
