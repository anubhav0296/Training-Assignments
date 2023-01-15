using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2_Reflection_Software_Attribute
{
    class SoftwareAttribute : Attribute
    {
        public String ProjectName { get; set; }
        public String Description { get; set; }
        public String ClientName { get; set; }
        public String StartedDate { get; set; }
        public String EndDate { get; set; }
    }
}
