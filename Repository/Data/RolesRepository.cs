using SIBKM_API.Context;
using SIBKM_API.Models;
using SIBKM_API.Repository.Interface;

namespace SIBKM_API.Repository.Data
{
    public class RolesRepository : GeneralRepository<Roles, int, MyContext>, IRolesRepository
    {
        public RolesRepository(MyContext context) : base(context) { }
    }
}
