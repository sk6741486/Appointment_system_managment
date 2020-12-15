using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Appointment_system_managment.Models;

namespace Appointment_system_managment.Data
{
    public class Appointment_system_managment_Database : DbContext
    {
        public Appointment_system_managment_Database (DbContextOptions<Appointment_system_managment_Database> options)
            : base(options)
        {
        }

        public DbSet<Appointment_system_managment.Models.patient_detail> patient_detail { get; set; }

        public DbSet<Appointment_system_managment.Models.doctor_detail> doctor_detail { get; set; }

        public DbSet<Appointment_system_managment.Models.clinic> clinic { get; set; }

        public DbSet<Appointment_system_managment.Models.appointment> appointment { get; set; }
    }
}
