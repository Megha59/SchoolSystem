using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolMS.Data.Entities
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Department_Id { get; set; }
    }
    class Course_Config: EntityTypeConfiguration<Course>
    {
        public Course_Config()
        {
            HasKey(e => new { e.Id, e.Department_Id });
        }
    }
}
