using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppCodeFirst.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Code { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(maximumLength:520)]
        public string Description { get; set; }
        
        public bool Status { get; set; }

        virtual public ICollection<Product> Products { get; set; }
    }
}
