using BlackCoffeeshop.Model;

namespace BlackCoffeeShop.Web.Models {
    public class ProductModels {

    }

    public class ProductCreateModel {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int ProductProductCategoryID { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductCost { get; set; }


        public string ProductCategoryCode { get; set; }
        public string ProductCategoryDescription { get; set; }
        public ProductType ProductCategoryProductType { get; set; }
    }
    public class ProductsCreateModel {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int ProductProductCategoryID { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductCost { get; set; }
        public IEnumerable<ProductCategory>? ProductCategories { get; set; }
    }

    public class ProductEditModel {
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int ProductProductCategoryID { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductCost { get; set; }
        public IEnumerable<ProductCategory>? ProductCategories { get; set; }
    }

    public class ProductDeleteModel {
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int ProductProductCategoryID { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductCost { get; set; }
    }
}
