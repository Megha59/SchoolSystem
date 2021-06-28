using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Data.Entities
{
    class School
    {
        public School()
        {
            Staffs = new HashSet<Staff>();
            Students = new HashSet<Student>();
            Registrations = new HashSet<Registration>();
            Departments = new HashSet<Department>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        
        public virtual ICollection<Staff> Staffs { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
