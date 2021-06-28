using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Data.Entities
{
    class Registration
    {
        public int Id { get; set; }
        public double Fees { get; set; }
        public int School_Id { get; set; }
        public virtual School School { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
