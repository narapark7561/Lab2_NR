using System.Reflection.Emit;

namespace NR_LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read employee data from a text file located on the specified path
            string[] employees = File.ReadAllLines("C:\\Users\\narapark7561\\Desktop\\SECOND SEMESTER\\CPRG211\\oop2 Labs\\LAB_2\\NR_LAB2\\NR_LAB2\\res\\employees.txt");
            List<Employee> employeeList = new List<Employee>();

            foreach (string employee in employees)
            {
                string[] employeeData = employee.Split(':');
                string id = employeeData[0];
                string name = employeeData[1];
                string address = employeeData[2];
                string phone = employeeData[3];
                long sin = long.Parse(employeeData[4]);
                string dob = employeeData[5];
                string dept = employeeData[6];
                double salaryOrRate = double.Parse(employeeData[7]);
                double hours = employeeData.Length > 8 ? double.Parse(employeeData[8]) : 0;

                // Determine the type of employee based on the first character of their ID
                char firstChar = id[0];
                if (firstChar >= '0' && firstChar <= '4')
                {
                    // Salaried employee
                    Salaried salariedEmployee = new Salaried(id, name, address, phone, sin, dob, dept, salaryOrRate);
                    employeeList.Add(salariedEmployee);
                }

                else if (firstChar >= '5' && firstChar <= '7')
                {
                    // Wage employee
                    Wages wageEmployee = new Wages(id, name, address, phone, sin, dob, dept, salaryOrRate, hours);
                    employeeList.Add(wageEmployee);
                }
                else if (firstChar >= '8')
                {
                    // Part-time employee
                    PartTime partTimeEmployee = new PartTime(id, name, address, phone, sin, dob, dept, salaryOrRate, hours);
                    employeeList.Add(partTimeEmployee);
                }
            }
            
            // Calculate the total and average weekly pay for all employees
            double totalPay = 0.0;

            foreach (Employee employee in employeeList)
            {
                double weeklyPay = employee.GetPay();
                totalPay += weeklyPay;
            }

            // Calculate and display the average weekly pay.
            double averageWeeklyPay = totalPay / employeeList.Count;
            Console.WriteLine($"Average weekly pay for all employees: {Math.Round(averageWeeklyPay, 2)}");

            double highestWeeklyPayWaged = 0.0;
            string highestPayNameWaged = null;

            // Find the waged employee with the highest weekly pay.
            foreach (Employee employee in employeeList)
            {
                if (employee is Wages)
                {
                    Wages wagesEmployee = (Wages)employee;
                    wagesEmployee.GetPay();

                    double weeklyPay = wagesEmployee.GetPay();

                    if (weeklyPay > highestWeeklyPayWaged)
                    {
                        highestWeeklyPayWaged = weeklyPay;
                        highestPayNameWaged = employee.Name;
                    }
                }
            }
            Console.WriteLine($"Highest waged employee: {highestPayNameWaged} with {highestWeeklyPayWaged}");

            double lowestWeeklyPaySalaried = double.MaxValue;
            string lowestPayNameSalaried = null;

            // Find the salaried employee with the lowest weekly pay.
            foreach (Employee employee in employeeList)
            {
                if (employee is Salaried)
                {
                    Salaried salariedEmployee = (Salaried)employee;
                    salariedEmployee.GetPay();

                    double weeklypay = salariedEmployee.GetPay();

                    if (weeklypay < lowestWeeklyPaySalaried && weeklypay > 0)
                    {
                        lowestWeeklyPaySalaried = weeklypay;
                        lowestPayNameSalaried = employee.Name;
                    }
                }
            }

            Console.WriteLine($"Lowest salaried employee: {lowestPayNameSalaried} with {lowestWeeklyPaySalaried}");

            // Count the number of each type of employee.
            int numOfSalaried = 0;
            int numOfWages = 0;
            int numOfPartTime = 0;
            int numOfTotalEmploee = employeeList.Count;

            foreach (Employee employee in employeeList)
            {
                if ( employee is Salaried )
                {
                    numOfSalaried++;
                }

                else if ( employee is Wages ) 
                {
                    numOfWages++;
                }

                else
                {
                    numOfPartTime++;
                }
            }

            double percentageSalaried = (double)numOfSalaried / numOfTotalEmploee * 100;
            double percentageWages = (double)numOfWages / numOfTotalEmploee * 100;
            double percentagePartTime = (double)numOfPartTime / numOfTotalEmploee * 100;

            Console.WriteLine($"The percentage of Salaried employees:  {Math.Round(percentageSalaried, 2)}%");
            Console.WriteLine($"The percentage of Wages employees: {Math.Round(percentageWages, 2)}%");
            Console.WriteLine($"The percentage of Part time employees: {Math.Round(percentagePartTime, 2)}%");
            
        }
    }
    }