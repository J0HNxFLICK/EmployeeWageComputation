namespace EmployeeWageComputation
{
    internal class EmployeeWageComputation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            const int present = 1;
            const int wagePerHr = 20;
            int fullDayHrs = 0;

            //UC1 Check employee is present or absent using RANDOM
            Random random = new Random();
            int fullTimeEmployee = random.Next(0, 2);
            if (fullTimeEmployee == present)
            {
                Console.WriteLine("The employee is present.");

                fullDayHrs += 8;
            }
            else
            {
                Console.WriteLine("The Employee is absent.");

                fullDayHrs += 0;
            }

            //UC2 Calculate daily employee wage
            int fullTimeWage = wagePerHr * fullDayHrs;
            Console.WriteLine("Total wage is : " + fullTimeWage);



        }
    }
}