using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Appointment_system_managment.Data;
using Appointment_system_managment.Models;

namespace Appointment_system_managment.Pages.Clinics
{
    public class IndexModel : PageModel
    {
        private readonly Appointment_system_managment.Data.Appointment_system_managment_Database _context;

        public IndexModel(Appointment_system_managment.Data.Appointment_system_managment_Database context)
        {
            _context = context;
        }

        public IList<clinic> clinic { get;set; }

        public async Task OnGetAsync()
        {
            clinic = await _context.clinic.ToListAsync();
        }
    }
}
