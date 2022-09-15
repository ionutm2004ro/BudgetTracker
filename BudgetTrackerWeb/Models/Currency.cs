using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BudgetTrackerWeb.Models
{
    public class Currency
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
