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
            int partTimeHrs = 0;
            Random random = new Random();


            //UC4 Solving using switch case statement
            Console.WriteLine("Enter an option :\n1 : Full-Time Employee.\n2 : Part - Time Employee.");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    //UC1 Check employee is present or absent using RANDOM
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
                    break;

                case 2:
                    //UC3 Add part time employee & wage
                    int partTimeEmployee = random.Next(0, 2);
                    if (partTimeEmployee == present)
                    {
                        Console.WriteLine("The part-time employee is present.");

                        partTimeHrs += 4;
                    }
                    else
                    {
                        Console.WriteLine("The part-time employee is absent.");

                        partTimeHrs += 0;
                    }

                    int partTimeWage = wagePerHr * partTimeHrs;
                    Console.WriteLine("Total wage is : " + partTimeWage);
                    break;
            }

        }
    }
}