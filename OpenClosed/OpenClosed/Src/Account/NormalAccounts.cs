using OpenClosed.Src.Applicants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Src.Accounts
{
    public class NormalAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{ person.LastName }@acme.com";
            output.employeeType = EmployeeType.Normal;

            return output;
        }
    }
}
