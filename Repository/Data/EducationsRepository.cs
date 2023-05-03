using SIBKM_API.Context;
using SIBKM_API.Models;
using SIBKM_API.Repository.Interface;

namespace SIBKM_API.Repository.Data
{
    public class EducationsRepository : GeneralRepository<Educations, int, MyContext>, IEducationRepository
    {
        public EducationsRepository(MyContext context) : base(context) { }

    }
}
