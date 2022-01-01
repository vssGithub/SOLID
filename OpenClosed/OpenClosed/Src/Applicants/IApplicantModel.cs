using OpenClosed.Src.Accounts;

namespace OpenClosed.Src.Applicants
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccounts AccountsProcessor { get; set; }
        EmployeeType employeeType { get; set; }
    }
}