using OpenClosed.Src.Applicants;

namespace OpenClosed.Src.Accounts
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}