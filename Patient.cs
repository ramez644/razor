using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testquery2fri
{
    internal class Patient
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DaoteOfBirth { get; set; }
        public string  gender { get; set; }

        public string PhoneNumber { get; set; }


        public ICollection<DoctorPatient> DoctorPatients { get; set; }

        public ICollection<Appointment> Appointments { get; set; }








    }
}
