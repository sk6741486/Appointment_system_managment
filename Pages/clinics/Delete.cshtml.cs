using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Appointment_system_managment.Data.ASM;
using Appointment_system_managment.Models;

namespace Appointment_system_managment.Pages.clinics
{
    public class DeleteModel : PageModel
    {
        private readonly Appointment_system_managment.Data.ASM.database _context;

        public DeleteModel(Appointment_system_managment.Data.ASM.database context)
        {
            _context = context;
        }

        [BindProperty]
        public clinic clinic { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            clinic = await _context.clinic.FirstOrDefaultAsync(m => m.ID == id);

            if (clinic == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            clinic = await _context.clinic.FindAsync(id);

            if (clinic != null)
            {
                _context.clinic.Remove(clinic);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
