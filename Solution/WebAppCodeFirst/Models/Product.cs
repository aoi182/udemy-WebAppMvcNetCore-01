using System.ComponentModel.DataAnnotations;

namespace WebAppCodeFirst.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Code { get; set; }

        [Required]
        [StringLength(maximumLength: 120, MinimumLength = 3)]
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal SellingPrice { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public bool Status { get; set; }

        virtual public Category Category { get; set; }
    }
}
