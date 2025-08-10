namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day6

            #region Q1
            /*
                -	Use the previous designed class Employee (at least has Name & Salary)
                   -	Design a new class Company. Each company has a Name, Budget and a list of working employees.
                   -	Add function IncreaseSalary(float amount) to class Employee that increases employee salary 
                       by the given amount. When this happen, the company must be notified by that increase so it decrease this amount from its budget.
                   -	In class Company, Write a function List<Employee> FilterEmployees(filter) that filters the employee list. 
                       (filter is a delegate of your choice)
                */
            //Company company = new Company("TechCorp", 10000f);

            //Employee e1 = new Employee("Alice", 3000f);
            //Employee e2 = new Employee("Bob", 4000f);
            //Employee e3 = new Employee("Charlie", 3500f);

            //company.AddEmployee(e1);
            //company.AddEmployee(e2);
            //company.AddEmployee(e3);

            //e1.IncreaseSalary(500);

            //Console.WriteLine("Budget:" + company);  // Budget: 9500

            //var highEarners = company.FilterEmployees(emp => emp.Salary > 3500);

            //Console.WriteLine("High earners:");
            //foreach (var emp in highEarners)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region Q2
            /*
                 لوصف:
                    صمّم فئة Product تحتوي على الخصائص التالية:

                    Name, Price, QuantityInStock

                    ودالة Sell(int quantity) تقوم بإنقاص الكمية وتُطلق حدثًا يخبر أن منتجًا قد بيع.

                    صمّم فئة Store تحتوي على:

                    Name, Revenue, وقائمة من Product

                    عند بيع منتج، يجب أن تُحدث الإيرادات (Revenue) في المتجر بناءً على السعر والكمية المباعة.
                 */
            Store store = new Store("Tech Store");

            Product laptop = new Product("Laptop", 2000f, 5);
            Product tv = new Product("TV", 1500f, 3);
            Product mouse = new Product("Mouse", 100f, 20);

            store.AddProduct(laptop);
            store.AddProduct(tv);
            store.AddProduct(mouse);

            // بيع بعض المنتجات
            laptop.Sell(2); // Revenue + 4000
            mouse.Sell(5);  // Revenue + 500

            Console.WriteLine();
            Console.WriteLine(store);

            // تصفية المنتجات بسعر > 1000
            var expensiveProducts = store.FilterProducts(p => p.Price > 1000);

            Console.WriteLine("\nFiltered products (Price > 1000):");
            foreach (var p in expensiveProducts)
            {
                Console.WriteLine(p);
            }
            #endregion

            #region Q3
            Bank bank = new Bank("Al Ahly");

            Account account1 = new Account("123", 10000);
            Account account2 = new Account("456", 20000);
            Account account3 = new Account("789", 15000);

            bank.AddAccount(account1);
            bank.AddAccount(account2);
            bank.AddAccount(account3);


            Console.WriteLine("Deposit:");
            account1.Deposit(5000);

            Console.WriteLine("Withdraw:");
            account2.Withdraw(5000);

            account3.Withdraw(20000);

            account1 = new CheckingAccount("131", 20000, 3000);

            bank.AddAccount(account1);

            account1.Withdraw(4000);

            #endregion

            #endregion
        }
    }
}
