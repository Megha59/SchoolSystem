using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolMS.Data.Entities
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual School School { get; set; }
        public virtual Registration Registration { get; set; }
    }
    
}
