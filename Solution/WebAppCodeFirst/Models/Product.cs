namespace WebAppCodeFirst.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SellingPrice { get; set; }
        public int Stock { get; set; }
        public bool Status { get; set; }

        virtual public Category Category { get; set; }
    }
}
