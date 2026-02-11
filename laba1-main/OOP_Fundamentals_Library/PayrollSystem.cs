namespace OOP_Fundamentals_Library
{
    public class PayrollSystem
    {

        public void ProcessSalary(Employee emp)
        {
            Console.WriteLine($"Processing payroll for: {emp.Name}");

            emp.ApplyRaise();
        }

        public void PrintBonus(Employee emp, int years, bool cert)
        {
         
            decimal bonus = emp.CalculateBonus(years, cert);
            Console.WriteLine($"Bonus for {emp.Name}: {bonus:C}");
        }
    }
}
