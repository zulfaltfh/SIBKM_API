using SIBKM_API.Context;
using SIBKM_API.Models;
using SIBKM_API.Repository.Interface;

namespace SIBKM_API.Repository.Data
{
    public class UniversityRepository : GeneralRepository<Universities, int, MyContext>, IUniversityRepository
    {
        public UniversityRepository(MyContext context) : base(context) { }
    }
}
