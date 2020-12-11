using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment_system_managment.Models
{
    //this class contain information about clinic//
    public class clinic
    {
      
        public int ID { get; set; }
        [Required]
        public string Clinic_name { get; set; }
        [Required]
        public string Clinic_address { get; set; }
        
        public string Clinic_phone { get; set; }
       
    }
}
