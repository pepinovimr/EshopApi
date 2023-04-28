﻿namespace EshopApi.Data.DTOs
{
    /// <summary>
    /// DTO of JSON from shop
    /// </summary>
    public class PurchaseOrderDTO
    {
        public string poid { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string item { get; set; }
        public int amount { get; set; }
        public float price { get; set; }
        public string createdon { get; set; }
    }
}
