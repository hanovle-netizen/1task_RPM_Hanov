namespace OOP_Fundamentals_Library
{
    public class Manager : Employee
    {
        public string Department { get; private set; }

     
        private List<Employee> _team = new();
        public IReadOnlyList<Employee> Team => _team.AsReadOnly();

        public Manager(string name, int age, decimal salary, string department)
            : base(name, age, salary, "Manager")
        {
            Department = department;
        }

        public void AddToTeam(Employee emp)
        {
            if (emp == null) throw new ArgumentNullException(nameof(emp));
            _team.Add(emp);
        }

       
        public override decimal CalculateBonus(int yearsWorked, bool hasCertification)
        {
          
            decimal bonus = Salary * 0.2m;

            
            if (yearsWorked > 5) bonus += 500;
            if (hasCertification) bonus += 300;

            return bonus;
        }

        public override void ApplyRaise()
        {
            Salary += 2000; 
            Console.WriteLine($"Зарплата менеджера {Name} повышена до {Salary}");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"[Manager] {Name}, Dept: {Department}, Team Size: {_team.Count}, Salary: {Salary:C}");
        }
    }
}
