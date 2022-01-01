using OpenClosed.Src.Applicants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Src.Accounts
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName }.{ person.LastName }@acmecorp.com";
            output.employeeType = EmployeeType.Executive;

            // with adding the enum for employeetype, these properties can be removed
            //output.IsManager = true;
            //output.IsExecutive = true;

            return output;
        }
    }
}
