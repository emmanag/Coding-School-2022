using BlackCoffeeshop.EF.Configuration;
using BlackCoffeeshop.Model;
using CoffeeShop.EF.Repositories;

namespace BlackCoffeeShop.Web {
    public class DummyDataHandler {

        public async Task Initialize() {

            var prodCatRepo = new ProductCategoryRepo(null);
            var prodRepo = new ProductRepo();

            var prodCat = new ProductCategory() {
                Code = "000002",
                Description = "Cappuccino",
                ProductType = ProductType.Coffee
            };
            await prodCatRepo.Create(prodCat);

            var prod = new Product() {
                Code = "000001",
                Description = "Cappuccino double",
                Price = 2.20m,
                Cost = 1.15m,
                ProductCategoryID = prodCat.ID
            };
            await prodRepo.Create(prod);

            var prodCat1 = new ProductCategory() {
                Code = "000003",
                Description = "Espresso",
                ProductType = ProductType.Coffee
            };
            await prodCatRepo.Create(prodCat1);

            var prod1 = new Product() {
                Code = "000002",
                Description = "Espresso single",
                Price = 1.40m,
                Cost = 0.75m,
                ProductCategoryID = prodCat1.ID
            };
            await prodRepo.Create(prod1);

            var prodCat2 = new ProductCategory() {
                Code = "000004",
                Description = "Sandwich",
                ProductType = ProductType.Food
            };
            await prodCatRepo.Create(prodCat2);

            var prod2 = new Product() {
                Code = "000003",
                Description = "Club Sandwich",
                Price = 5.50m,
                Cost = 2.35m,
                ProductCategoryID = prodCat2.ID
            };
            await prodRepo.Create(prod2);

            // CUSTOMERS AND EMPLOYEES
            var customerRepo = new CustomerRepo();
            var employeeRepo = new EmployeeRepo();

            var customer = new Customer() {
                Code = "000001",
                Description = "Retail"
            };
            await customerRepo.Create(customer);

            var employee = new Employee() {
                EmployeeType = EmployeeType.Cashier,
                Name = "Takis",
                Surname = "Papadakis",
                SalaryPerMonth = 900
            };
            await employeeRepo.Create(employee);


            // TRANSACTIONS AND TRANSACTIONLINES

/*            var transactionRepo = new TransactionRepo();
            var transactionLineRepo = new TransactionLineRepo();


            var transaction1 = new Transaction() {
                Date = DateTime.Now,
                PaymentMethod = PaymentMethod.Cash,
                CustomerID = customer.ID,
                EmployeeID = employee.ID

            };
            await transactionRepo.Create(transaction1);

            var transactionLine = new TransactionLine() {
                TransactionID = transaction1.ID,
                ProductID = prod.ID,
                Price = prod.Price,
                Discount = 0,
                Quantity = 2,
                TotalPrice = prod.Price * 2,
            };
            await transactionLineRepo.Create(transactionLine);
*/
        }

    }
}
