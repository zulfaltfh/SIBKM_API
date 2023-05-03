using SIBKM_API.Context;
using SIBKM_API.Models;
using SIBKM_API.Repository.Interface;

namespace SIBKM_API.Repository.Data
{
    public class AccountsRepository : GeneralRepository<Accounts, string, MyContext>, IAccountsRepository
    {
        public AccountsRepository(MyContext context) : base(context) { }

    }
}
