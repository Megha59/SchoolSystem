using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Data.Entities
{
    class Department
    {
        public Department()
        {
            Courses = new HashSet<Course>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        
    }
}
