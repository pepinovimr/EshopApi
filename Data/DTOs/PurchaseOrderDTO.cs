using EshopApi.Data.Validation.Attributes;

namespace EshopApi.Data.DTOs
{
    /// <summary>
    /// DTO of JSON from shop
    /// </summary>
    public class PurchaseOrderDTO
    {
        [Truncate(10)]
        public string poid { get; set; }
        [Truncate(30)]
        public string first_name { get; set; }
        [Truncate(30)]
        public string last_name { get; set; }
        [Truncate(30)]
        public string email { get; set; }
        [Truncate(50)]
        public string item { get; set; }
        public int amount { get; set; }
        public float price { get; set; }
        [Truncate(7)]
        public string createdon { get; set; }
    }
}
