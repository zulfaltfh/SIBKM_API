using SIBKM_API.Context;
using SIBKM_API.Models;
using SIBKM_API.Repository.Interface;
using SIBKM_API.ViewModels;

namespace SIBKM_API.Repository.Data
{
    public class AccountsRepository : GeneralRepository<Accounts, string, MyContext>, IAccountsRepository
    {
        public AccountsRepository(MyContext context) : base(context) { }

        public int Register(RegisterVM registerVM)
        {
            int result = 0;

            //insert to University table
            var university = new Universities
            {
                Name = registerVM.UniversityName
            };
            _context.Set<Universities>().Add(university);
            result = _context.SaveChanges();

            //insert to Education table
            var education = new Educations
            {
                Major = registerVM.Major,
                Degree = registerVM.Degree,
                GPA = registerVM.GPA,
                UniversityId = university.Id
            };
            _context.Set<Educations>().Add(education);
            result = _context.SaveChanges();

            //insert to Employee table
            var employee = new Employee
            {
                NIK = registerVM.NIK,
                FirstName = registerVM.FirstName,
                LastName = registerVM.LastName,
                BirthDate = registerVM.BirthDate,
                Gender = registerVM.Gender,
                HiringDate = DateTime.Now,
                Email = registerVM.Email,
                PhoneNumber = registerVM.PhoneNumber
            };
            _context.Set<Employee>().Add(employee);
            result = _context.SaveChanges();

            //insert to Account table
            var account = new Accounts
            {
                EmployeeNIK = registerVM.NIK,
                Password = registerVM.Password,
            };
            _context.Set<Accounts>().Add(account);
            result = _context.SaveChanges();

            //insert to Profiling table
            var profiling = new Profilings
            {
                EmployeeNIK = registerVM.NIK,
                EducationId = education.Id
            };
            _context.Set<Profilings>().Add(profiling);
            result = _context.SaveChanges();

            //insert to AccountRole table
            var accRole = new AccountRoles
            {
                AccountNIK = registerVM.NIK,
                RoleId = 1 //default as user
            };
            _context.Set<AccountRoles>().Add(accRole);
            result = _context.SaveChanges();

            return result;
        }
    }
}
