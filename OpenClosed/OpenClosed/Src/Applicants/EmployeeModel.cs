using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Src.Applicants
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsManager { get; set; } = false;
        public bool IsExecutive { get; set; } = false;
        public EmployeeType employeeType { get; set; }
    }
}
