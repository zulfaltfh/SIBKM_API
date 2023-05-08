using SIBKM_API.Models;

namespace SIBKM_API.Repository.Interface
{
    public interface IEmployeeRepository : IGeneralRepository<Employee, string>
    {
        string GetFullNameByEmail(string email);
    }
}
