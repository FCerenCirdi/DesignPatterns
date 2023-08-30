namespace DesignPattern.Composite.Practice.CompositePattern
{
    public class EmployeeComponent : IComponent
    {
        public EmployeeComponent(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get ; set ; }
        public string Name { get; set; }

        public string Display()
        {
            return $"<li class='list-group-item'>{Name}</li>";
        }

        public int TotalEmployee()
        {
            return 1;
        }
    }
}
