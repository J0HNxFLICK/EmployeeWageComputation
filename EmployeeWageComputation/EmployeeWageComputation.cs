namespace EmployeeWageComputation
{
    internal class Calculator
    {
        const int present = 1;
        int absentCounter = 0;
        int day = 0;
        int hrs = 0;
        int wagePerHr = 0;
        int minimumWorkingDays = 0;
        int minimumWorkingHrs = 0;
        string companyName;
        Random random = new Random();

        public Calculator(int wagePerHr, int minimumWorkingDays, int minimumWorkingHrs, string companyName) 
        {
            this.minimumWorkingDays= minimumWorkingDays; // UC9 Using instance variables
            this.minimumWorkingHrs= minimumWorkingHrs;
            this.companyName= companyName;
            this.wagePerHr= wagePerHr;

            brain();
        }



        public void brain ()
        {
            Console.WriteLine("Enter an option :\n1 : Full-Time Employee.\n2 : Part - Time Employee.");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)  //UC4 Solving using switch case statement
            {
                case 1:

                    //for (int day =1; day <= daysPerMonth; day ++) //UC5 Calculating wages for a month 
                    //{
                    //    //UC1 Check employee is present or absent using RANDOM
                    //    int fullTimeEmployee = random.Next(0, 2);
                    //    if (fullTimeEmployee == present)
                    //    {
                    //        //Console.WriteLine("The employee is present.");

                    //        fullDayHrs += 8;
                    //    }
                    //    else
                    //    {
                    //        //Console.WriteLine("The Employee is absent.");

                    //        fullDayHrs += 0;
                    //        absentCounter++;
                    //    }
                    //}

                    while (day <= this.minimumWorkingDays || hrs <= this.minimumWorkingHrs) // UC6 Calculating wages till a condition is met
                    {
                        int fullTimeEmployee = random.Next(0, 2);
                        if (fullTimeEmployee == present)
                        {
                            day++;
                            hrs += 8;
                        }
                        else
                        {
                            hrs += 0;
                            day += 0;
                            absentCounter++;
                        }
                    }

                    //UC2 Calculate daily employee wage
                    int fullTimeWage = WageCalculator(this.wagePerHr, hrs);
                    Console.WriteLine("Full-time employee is absent for {0} day(s), total wage after minimum work requirement is {1}.", absentCounter, fullTimeWage);

                    break;

                case 2:

                    //for (int day = 1; day <= daysPerMonth; day++) //UC5 Calculating wages for a month
                    //{
                    //    //UC3 Add part time employee & wage
                    //    int partTimeEmployee = random.Next(0, 2);
                    //    if (partTimeEmployee == present)
                    //    {
                    //        //Console.WriteLine("The part-time employee is present.");

                    //        partTimeHrs += 4;
                    //    }
                    //    else
                    //    {
                    //        //Console.WriteLine("The part-time employee is absent.");

                    //        partTimeHrs += 0;
                    //        absentCounter++;
                    //    }
                    //}

                    while (day <= this.minimumWorkingDays || hrs <= this.minimumWorkingHrs) // UC6 Calculating wages till a condition is met
                    {
                        int partTimeEmployee = random.Next(0, 2);
                        if (partTimeEmployee == present)
                        {
                            day++;
                            hrs += 4;
                        }
                        else
                        {
                            hrs += 0;
                            day += 0;
                            absentCounter++;
                        }
                    }

                    int partTimeWage = WageCalculator(this.wagePerHr, hrs);
                    Console.WriteLine("Part-time employee is absent for {0} day(s), total wage after minimum work requirement is {1}.", absentCounter, partTimeWage);

                    break;

                default:
                    Console.WriteLine("Choose a valid option.");
                    break;

            }
        }

        static int WageCalculator(int perHrRate, int hours) // UC7 Calculating employee wage using class method
        {
            int wage = perHrRate * hours;
            return wage;
        }
    }

    internal class EmployeeWageComputation 
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            //Console.WriteLine("KTM Group");
            //Calculator(30, 30, 8); // UC 8 Calculating for multiple companies

            //Console.WriteLine("Royal Enfield");
            //Calculator(35, 25, 7);

            Console.WriteLine("Enter company name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter minimum working days : ");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minimum working hrs : ");
            int hrs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter wage per hr : ");
            int hrlyWage = Convert.ToInt32(Console.ReadLine());

            Calculator calculator = new Calculator(hrlyWage, days, hrs, name);


        }
    }
}