using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testquery2fri
{
    internal class Department
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public string Head { get; set; }
        public string Location { get; set; }


        public ICollection<Doctor>doctors { get; set; }





    }
}
