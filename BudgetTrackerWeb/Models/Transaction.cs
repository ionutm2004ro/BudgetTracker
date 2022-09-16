using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BudgetTrackerWeb.Models
{
    public class Transaction
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }
        [Required]
        [Range(0.0,float.MaxValue,ErrorMessage = "The value must be positive")]
        public float Value { get; set; }
        [MaxLength(200)]
        public string Note { get; set; } = string.Empty;
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [MaxLength(50)]
        public string Currency { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Category { get; set; } = string.Empty;
    }
}