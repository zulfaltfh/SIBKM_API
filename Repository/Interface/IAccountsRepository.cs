using SIBKM_API.Models;
using SIBKM_API.ViewModels;

namespace SIBKM_API.Repository.Interface
{
    public interface IAccountsRepository : IGeneralRepository<Accounts, string>
    {
        int Register (RegisterVM registerVM);
        //bool Login(LoginVM loginVM);
    }
}
