using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.CliniqueManagement
{
    class Appointment
    {
        public string DoctorName { get; set; }
        public string AppointmentDateTime { get; set; }
        public List<PatientAppointment> PatientAppointments { get; set; }
    }
}
