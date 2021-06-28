using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolMS.Data.Entities
{
    class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Post_Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public int School_Id { get; set; }
        public virtual School  School { get; set; }
    }
    class Staff_Config : EntityTypeConfiguration<Staff>
    {
        public Staff_Config()
        {
            
        }
    }
}