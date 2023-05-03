using SIBKM_API.Context;
using SIBKM_API.Models;
using SIBKM_API.Repository.Interface;

namespace SIBKM_API.Repository.Data
{
    public class AccountRolesRepository : GeneralRepository<AccountRoles, int, MyContext>, IAccountRolesRepository
    {
        public AccountRolesRepository(MyContext context) : base(context) { }
    }
}
