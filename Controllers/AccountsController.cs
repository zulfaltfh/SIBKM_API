﻿using SIBKM_API.Controllers.BaseController;
using SIBKM_API.Models;
using SIBKM_API.Repository.Interface;
using SIBKM_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace SIBKM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : GeneralController<IAccountsRepository, Accounts, string>
    {
        public AccountsController(IAccountsRepository accountsRepository) : base(accountsRepository) { }
    }
}