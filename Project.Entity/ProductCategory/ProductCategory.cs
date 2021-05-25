namespace Project.Entity.ProductCategory
{
    public class ProductCategory
    {
        public Product.Product Product { get; set; }
        public int ProductId { get; set; }
        public Category.Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
