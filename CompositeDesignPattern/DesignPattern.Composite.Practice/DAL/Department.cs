namespace DesignPattern.Composite.Practice.DAL
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public int SubDepartmentID { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
