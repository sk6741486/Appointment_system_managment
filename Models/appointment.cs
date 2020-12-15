using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment_system_managment.Models
{
    //this class contain  information about relation between other class through this class//
    public class appointment
    {
        
        public int Id { get; set; }

        public int Clinic_registration_no { get; set; }
        public clinic clinic { get; set; }

        public int Doctor_ID { get; set; }
        public doctor_detail doctor_detail { get; set; }
        public int Patient_registration_no { get; set; }
        public patient_detail patient_detail { get; set; }
        public DateTime Appointment_date_time { get; set; }
       
    }
}
