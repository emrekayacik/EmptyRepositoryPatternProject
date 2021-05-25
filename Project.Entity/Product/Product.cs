using System;
using System.Collections.Generic;

namespace Project.Entity.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Modifier { get; set; }
        public bool IsDeleted { get; set; }
        public Category.Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<ProductCategory.ProductCategory> ProductCategories { get; set; }
    }
}
