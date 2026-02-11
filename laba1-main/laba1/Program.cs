using OOP_Fundamentals_Library;

namespace laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
   
                var customer = new Customer("John Client", 30);

                var dev = new Employee("Alice Dev", 25, 50000, "Developer");

                var manager = new Manager("Bob Boss", 40, 80000, "IT");

                manager.AddToTeam(dev);

                ReportService.GenerateReport(customer);
                ReportService.GenerateReport(dev);
                ReportService.GenerateReport(manager);

           
                var payroll = new PayrollSystem();

              
                payroll.PrintBonus(dev, 6, true);     
                payroll.PrintBonus(manager, 6, true);  

           
                payroll.ProcessSalary(dev);    
                payroll.ProcessSalary(manager);

                Console.WriteLine("\nAfter Raise:");
                dev.PrintInfo();
                manager.PrintInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
