using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [NotMapped]
        public double TotalPrice { get => PricePerUnit * Amount; }

    }
}
