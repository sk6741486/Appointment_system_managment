using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment_system_managment.Model
{
    //this class use for disply the detail of doctor//
    public class doctor_detail
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        [Required]
        public string Sepicaligation { get; set; }
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

    }
}
