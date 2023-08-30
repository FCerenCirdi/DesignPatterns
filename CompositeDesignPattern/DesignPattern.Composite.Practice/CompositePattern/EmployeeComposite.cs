using System.Text;

namespace DesignPattern.Composite.Practice.CompositePattern
{
    public class EmployeeComposite : IComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private List<IComponent> _components;

        public EmployeeComposite(int ıd, string name)
        {
            Id = ıd;
            Name = name;
            _components = new List<IComponent>();
        }
        public ICollection<IComponent> Components => _components;
        public void Add(IComponent component)
        {
            _components.Add(component);
        }
        public string Display()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"<div class='text-success'>{Name} ({TotalEmployee()})</div>");
            stringBuilder.Append("<ul class='list-group list-group-flush ms-2'>");
            foreach (var item in _components)
            {
                stringBuilder.Append(item.Display());
            }
            stringBuilder.Append("</ul>");
            return stringBuilder.ToString();
        }

        public int TotalEmployee()
        {
            return _components.Sum(x => x.TotalEmployee());
        }
    }
}

