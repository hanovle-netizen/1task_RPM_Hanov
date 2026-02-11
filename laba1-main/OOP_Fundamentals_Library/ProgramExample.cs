namespace OOP_Fundamentals_Library
{
 
using OOP_Fundamentals_Library;

namespace laba1
    {
        internal class ProgramExample
        {
            static void Main(string[] args)
            {
                try
                {
                    
                    var customer = new Customer("John", 30);

                    var employee = new Employee("Alice", 25, 50000, "Developer");

                    var manager = new Manager("Bob", 40, 80000, "IT");

         
                    manager.AddToTeam(employee);

                   
                    Console.WriteLine("--- Повышение зарплаты через бизнес-логику ---");
                  
                    Console.WriteLine("\n--- Информация о сотрудниках ---");
                    customer.PrintInfo();
                    employee.PrintInfo();
                    manager.PrintInfo();

                    Console.WriteLine("\n--- Обработка зарплат ---");
                    var payroll = new PayrollSystem();

                   
                    payroll.ProcessSalary(employee); 
                    payroll.ProcessSalary(manager);  

                  
                    Console.WriteLine("\n--- Генерация отчетов ---");
                    
                    ReportService.GenerateReport(employee);
                    ReportService.GenerateReport(manager);
                 
                    ReportService.GenerateReport(customer);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }

                Console.ReadKey();
            }
        }
    }
}