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
        [AllowNull]
        public string Note { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [AllowNull]
        public string Currency { get; set; }
        [AllowNull]
        public string Category { get; set; }
    }
}