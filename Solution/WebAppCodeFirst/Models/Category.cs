﻿using System.Collections.Generic;

namespace WebAppCodeFirst.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }

        virtual public ICollection<Product> Products { get; set; }
    }
}
