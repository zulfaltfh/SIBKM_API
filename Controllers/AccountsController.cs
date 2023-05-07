using SIBKM_API.Models;
using SIBKM_API.Repository.Interface;
using SIBKM_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using SIBKM_API.BaseController;

namespace SIBKM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : GeneralController<IAccountsRepository, Accounts, string>
    {
        public AccountsController(IAccountsRepository accountsRepository) : base(accountsRepository) { }

        [HttpPost("Login")]
        public ActionResult Login(LoginVM loginVM)
        {
            var login = _repository.Login(loginVM);
            if (login)
            {
                return Ok(new ResponseDataVM<string>
                {
                    Code = StatusCodes.Status200OK,
                    Status = HttpStatusCode.OK.ToString(),
                    Message = "Login Success"
                });
            }
            return NotFound(new ResponseErrorsVM<string>
            {
                Code = StatusCodes.Status500InternalServerError,
                Status = HttpStatusCode.InternalServerError.ToString(),
                Errors = "Login Failed, Account or Password Not Found!"
            });
        }

        [HttpPost("Register")]
        public ActionResult Register(RegisterVM registerVM)
        {
            var register = _repository.Register(registerVM);
            if (register > 0)
            {
                return Ok(new ResponseDataVM<string>
                {
                    Code = StatusCodes.Status200OK,
                    Status = HttpStatusCode.OK.ToString(),
                    Message = "Insert Success"
                });
            }

            return BadRequest(new ResponseErrorsVM<string>
            {
                Code = StatusCodes.Status500InternalServerError,
                Status = HttpStatusCode.InternalServerError.ToString(),
                Errors = "Insert Failed / Lost Connection"
            });
        }
    }
}
