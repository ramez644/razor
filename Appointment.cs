using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testquery2fri
{
    internal class Appointment
    {

        public int Id { get; set; }


        public DateTime AppointmentDate { get; set; }

        public string Reason { get; set; }



        public Patient patient { get; set; }
        public int patientId { get; set; }



        public Doctor doctor { get; set; }
        public int doctorId { get; set; }
       











    }
}
