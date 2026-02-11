namespace OOP_Fundamentals_Library
{
    public class Employee : Person
    {
        private decimal _salary;

        public decimal Salary
        {
            get => _salary;
            protected set
            {
                if (value < 0) throw new ArgumentException("Зарплата не может быть отрицательной");
                _salary = value;
            }
        }

        public string Position { get; private set; }

        public Employee(string name, int age, decimal salary, string position)
            : base(name, age)
        {
            Salary = salary;
            Position = position;
        }

        
        public virtual decimal CalculateBonus(int yearsWorked, bool hasCertification)
        {
            decimal bonus = Salary * 0.1m;
            if (yearsWorked > 5) bonus += 500;
            if (hasCertification) bonus += 300;
            return bonus;
        }

        
        public virtual void ApplyRaise()
        {
            Salary += 1000; 
            Console.WriteLine($"Зарплата {Name} повышена до {Salary}");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"[Employee] {Name}, Position: {Position}, Salary: {Salary:C}");
        }
    }
}
