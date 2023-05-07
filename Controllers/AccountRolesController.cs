using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIBKM_API.BaseController;
using SIBKM_API.Models;
using SIBKM_API.Repository.Interface;

namespace SIBKM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountRolesController : GeneralController<IAccountRolesRepository, AccountRoles, int>
    {
        public AccountRolesController(IAccountRolesRepository repository) : base(repository) { }
    }
}
