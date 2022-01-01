using OpenClosed.Src.Applicants;
using System;
using System.Collections.Generic;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey"},
                new ManagerModel { FirstName = "Sue", LastName = "Storm"},
                new ExecutiveModel { FirstName = "Nancy", LastName = "Roman"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach(var person in applicants)
            {
                employees.Add(person.AccountsProcessor.Create(person));
            }

            foreach(var employee in employees)
            {
                //Console.WriteLine($"{employee.FirstName} {employee.LastName} : {employee.EmailAddress} EmployeeType: {employee.employeeType} IsManager: {employee.IsManager} IsExecutive: {employee.IsExecutive}");
                Console.WriteLine($"{employee.FirstName} {employee.LastName} : {employee.EmailAddress} EmployeeType: {employee.employeeType}");
            }

            Console.ReadLine();
        }
    }
}
