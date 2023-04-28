using System.ComponentModel.DataAnnotations;

namespace EshopApi.Data.Model
{
    /// <summary>
    /// For validation of sender
    /// </summary>
    public class CompanyKeys
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int CompanyKey { get; set; }
        [Required]
        [MaxLength(50)]
        public string CompanyHash { get; set; }

    }
}
