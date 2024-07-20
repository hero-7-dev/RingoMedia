using System.Collections.Generic;

namespace RingoMedia.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public int? ParentDepartmentId { get; set; }

        public Department ParentDepartment { get; set; }
        public ICollection<Department> SubDepartments { get; set; }
    }

}
