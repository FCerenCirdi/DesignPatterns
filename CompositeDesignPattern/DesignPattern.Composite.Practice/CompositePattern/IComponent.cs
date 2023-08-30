namespace DesignPattern.Composite.Practice.CompositePattern
{
    public interface IComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        int TotalEmployee();
        string Display();
    }
}
