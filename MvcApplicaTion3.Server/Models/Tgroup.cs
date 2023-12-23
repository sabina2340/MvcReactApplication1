namespace MvcApplicaTion3.Server.Models
{
    public class Tgroup
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public List<TProperty> Properties { get; set; } = new List<TProperty>();
        public List<Tproperty> Properties { get; set; } = new List<Tproperty>();
    }
}
