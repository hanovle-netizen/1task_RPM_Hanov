namespace OOP_Fundamentals_Library
{
    public class ReportService
    {
      
        public static void GenerateReport(Person person)
        {
            Console.WriteLine("--- Report Start ---");
            person.PrintInfo(); 
            Console.WriteLine("--- Report End ---\n");
        }
    }
}
