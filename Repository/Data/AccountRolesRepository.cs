﻿using SIBKM_API.Context;
using SIBKM_API.Models;
using SIBKM_API.Repository.Interface;

namespace SIBKM_API.Repository.Data
{
    public class AccountRolesRepository : GeneralRepository<AccountRoles, int, MyContext>, IAccountRolesRepository
    {
        public AccountRolesRepository(MyContext context) : base(context) { }

        public IEnumerable<string> GetRolesByEmail(string email)
        {
            var getEmployeeNIK = _context.Employees.FirstOrDefault(e => e.Email == email)!.NIK;
            var getAccountRoles = _context.AccountRoles
                                   .Where(ar => ar.AccountNIK == getEmployeeNIK)
                                   .Join(_context.Roles,
                                         ar => ar.RoleId,
                                         r => r.Id,
                                         (ar, r) => new { ar, r })
                                   .Select(role => role.r.Name);

            return getAccountRoles;
        }
    }
}
