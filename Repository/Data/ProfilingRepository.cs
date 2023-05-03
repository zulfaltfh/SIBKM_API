using SIBKM_API.Context;
using SIBKM_API.Models;
using SIBKM_API.Repository.Interface;

namespace SIBKM_API.Repository.Data
{
    public class ProfilingRepository : GeneralRepository<Profilings, string, MyContext>, IProfilingRepository
    {
        public ProfilingRepository(MyContext context) : base(context) { }

    }
}
