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
    public class EmployeeController : GeneralController<IEmployeeRepository, Employee, string>
    {
        public EmployeeController(IEmployeeRepository repository) : base(repository) { }

    }
}
