namespace DesignPattern.Composite.Practice.DAL
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Position { get; set; }

        public Department Department { get; set; }
        public int DepartmentID { get; set; }
    }
}
