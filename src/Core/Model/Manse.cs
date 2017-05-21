namespace ManseBuilder.Core.Model
{
    public class Manse : BaseAggregate
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public Demesne Demesne { get; set; }
        public Aspect Aspect { get; set; }
    }
}