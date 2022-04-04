using BlackCoffeeshop.Model;

namespace BlackCoffeeShop.Web.Models
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }
        
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }

    public class EmployeeDetailsModel
    {
        public int ID { get; set; }
       
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
    public class EmployeeEditModel
    {
        public int ID { get; set; }
        
        
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
    public class EmployeeCreateModel
    {
        public int ID { get; set; }
        
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
    public class EmployeeDeleteModel
    {
        public int ID { get; set; }
        
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
    public class EmployeeModel
    {
        public int ID { get; set; }
        
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
