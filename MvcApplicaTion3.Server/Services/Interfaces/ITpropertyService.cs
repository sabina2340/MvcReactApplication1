using System.Collections.Generic;

namespace MvcApplicaTion3.Server.Services.Interfaces
{
    public interface ITpropertyService
    {
        Tproperty Get(int id);
        List<Tproperty> Get();
        DbSet<Tproperty> Get();
        void Delete(int id);
    }
}
