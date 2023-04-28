namespace EshopApi.Data.DTOs
{
    public class PurchaseOrderResponseDTO
    {
        public int Succeded { get; set; }
        public int Failed { get; set; }

        public List<PurchaseIdPairDTO> IdPairs { get; set; } = new List<PurchaseIdPairDTO>();
    }
}
