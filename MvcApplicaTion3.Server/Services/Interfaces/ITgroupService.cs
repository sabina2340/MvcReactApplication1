using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MvcApplicaTion3.Server.Services.Interfaces
{
    public interface ITgroupService
    {
        Tgroup Get(int id);

        List<Tgroup> Get();
        DbSet<Tgroup> Get();

        void Delete(int id);
    }
    
}
