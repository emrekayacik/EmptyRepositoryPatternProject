using System;
using System.Collections.Generic;

namespace Project.Entity.Category
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string Creator { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Modifier { get; set; }
        public bool IsDeleted { get; set; }
        public List<ProductCategory.ProductCategory> ProductCategories { get; set; }

    }
}
