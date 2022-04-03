using BlackCoffeeshop.Model;

namespace BlackCoffeeShop.Web.Models {
    public class ProductCategoryViewModel {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
    }

    public class ProductCategoryDetailsModel {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
    }
    public class ProductCategoryEditModel {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
    }
    public class ProductCategoryCreateModel {
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
    }
    public class ProductCategoryDeleteModel {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
    }
    public class ProductCategoryModel {
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
    }
}
