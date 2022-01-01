using OpenClosed.Src.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Src.Applicants
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountsProcessor { get; set; } = new ManagerAccounts();
        public EmployeeType employeeType { get ; set ; }
    }
}
