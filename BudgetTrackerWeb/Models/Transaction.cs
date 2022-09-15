using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BudgetTrackerWeb.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
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