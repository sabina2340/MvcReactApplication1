using System.Collections.Generic;

namespace MvcApplicaTion3.Server.Services.Interfaces
{
    public interface ITrelationService
    {
        Trelation Get(int id);
        List<Trelation> Get();
        DbSet<Trelation> Get();
        void Delete(int id);
    }
}
