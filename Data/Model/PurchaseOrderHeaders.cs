using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EshopApi.Data.Model
{
    public class PurchaseOrderHeaders
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string PoNumber { get; set; }
        [Required]
        [MaxLength(30)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(30)]
        public string CustomerLastName { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public bool IsPaid { get; set; } = false;
        [Required]
        [MaxLength(30)]
        public string CustomerEmail { get; set; }
        [ForeignKey("PurchaserOrderId")]
        public virtual List<PurchaseOrderItems> PurchaseOrderItems { get; set; }
    }
}
