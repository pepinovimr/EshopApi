using System.ComponentModel.DataAnnotations;

namespace EshopApi.Data.Model
{
    public class PurchaseOrderItems
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int PurchaserOrderId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ShopItemTitle { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public double PricePerUnit { get; set; }

    }
}
