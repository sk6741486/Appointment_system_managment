﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment_system_managment.Model
{
    //This class shows all informatoin about my patient detail including name, adress,phone, dob and registration no etc// 
    public class patient_detail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
      
    }
}
