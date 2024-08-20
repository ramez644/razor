using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testquery2fri
{
    internal class Doctor
    {
        public int Id { get; set; }


        public string  Name { get; set; }

        public string Speciality { get; set; }

        public int YoxEeperience { get; set; }


        public string  Email { get; set; }



        public Department department { get; set; }

        public int departmentId { get; set; }

        public ICollection<DoctorPatient> DoctorPatients { get; set; }

        public ICollection<Appointment> Appointments { get; set; }


    }
}
