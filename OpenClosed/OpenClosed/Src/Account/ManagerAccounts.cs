using OpenClosed.Src.Applicants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Src.Accounts
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{ person.LastName }@acmecorp.com";
            output.employeeType = EmployeeType.Manager;

            // with adding the enum for employeetype, this property can be removed
            //output.IsManager = true;

            return output;
        }
    }
}
