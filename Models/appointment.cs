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

        public int ClinicId { get; set; }
        public clinic Clinic { get; set; }
        public int Doctor_DetailID { get; set; }
        public doctor_detail Doctor_Detail { get; set; }
        public int Patient_DetailID { get; set; }
        public patient_detail Patient_Detail { get; set; }
        public DateTime Appointment_date_time { get; set; }

    }
}