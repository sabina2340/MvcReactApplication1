using System.Collections.Generic;

namespace MvcApplicaTion3.Server.Models
{
    public class Trelation
    {
        Trelation Get(int id);

        List<Trelation> Get();
        DbSet<Trelation> Get();

        void Delete(int id);
    }
}
