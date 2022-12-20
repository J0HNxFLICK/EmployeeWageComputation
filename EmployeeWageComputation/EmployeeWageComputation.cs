namespace EmployeeWageComputation
{
    internal class EmployeeWageComputation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            const int present = 1;

            //UC1 Check employee is present or absent using RANDOM
            Random random = new Random();
            int fullTimeEmployee = random.Next(0, 2);
            if (fullTimeEmployee == present)
            {
                Console.WriteLine("The employee is present.");
            }
            else
            {
                Console.WriteLine("The Employee is absent.");
            }
        }
    }
}