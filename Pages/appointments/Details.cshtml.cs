using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Appointment_system_managment.Data.ASM;
using Appointment_system_managment.Models;

namespace Appointment_system_managment.Pages.appointments
{
    public class DetailsModel : PageModel
    {
        private readonly Appointment_system_managment.Data.ASM.database _context;

        public DetailsModel(Appointment_system_managment.Data.ASM.database context)
        {
            _context = context;
        }

        public appointment appointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            appointment = await _context.appointment.FirstOrDefaultAsync(m => m.ID == id);

            if (appointment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
