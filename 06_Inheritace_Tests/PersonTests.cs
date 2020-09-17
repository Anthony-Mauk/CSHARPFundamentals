using System;
using System.Collections.Generic;
using _06_Inheritance_Classes2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Inheritace_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldSetCorrectly()
        {
            Person martha = new Person();
            martha.SetFirstame("Martha"); //sets first name through method
            martha.SetLastName("Vineyard");//sets last name through method
            Console.WriteLine(martha.Name);

            Customer bob = new Customer();
            bob.SetFirstame("Bobert");
            bob.SetLastName("Boss");
            Console.WriteLine(bob.Name);

            //set properties via a block
            SalaryEmployee tedEmployee = new SalaryEmployee
            {
                PhoneNumber = "1-800-fakenum",
                Salary = 800000,
                HireDate = new DateTime(1304, 01, 01),
                EmployeeNumber = 394
            }; //need semicolon
            Console.WriteLine(tedEmployee.YearsWithCompany);
        }
        [TestMethod]
        public void EmployeeTestsAKAStarkTower()
        {
            Employee jarvis = new Employee();
            HourlyEmployee tony = new HourlyEmployee();
            SalaryEmployee pepper = new SalaryEmployee();
            tony.HoursWorked = 55;
            tony.HourlyWage = 3000;
            pepper.Salary = 200000;
            HourlyEmployee peter = new HourlyEmployee();
            SalaryEmployee happy = new SalaryEmployee();
            happy.Salary = 150000;
            jarvis.SetFirstame("Jarvis");
            tony.SetFirstame("Tony");
            pepper.SetFirstame("Pepper");
            peter.SetFirstame("Peter");
            happy.SetFirstame("Happy");
            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(jarvis);
            allEmployees.Add(tony);
            allEmployees.Add(pepper);
            allEmployees.Add(peter);
            allEmployees.Add(happy);

            foreach(Employee worker in allEmployees)
            {
                if (worker.GetType() == typeof(SalaryEmployee))//asks if SalaryEmployee
                {
                    SalaryEmployee sEmployee = (SalaryEmployee)worker;//casting
                    //changes worker into salaryemployee
                    Console.WriteLine($"This is a salaray employee that makes {sEmployee.Salary}");
                }
                else if (worker is HourlyEmployee hourlyWorker)// pattern matching
                {
                    Console.WriteLine($"{worker.Name} has worked {hourlyWorker.HoursWorked} hours!");
                }
            }
        }
    }
}
