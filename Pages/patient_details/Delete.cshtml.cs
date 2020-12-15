using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Appointment_system_managment.Data;
using Appointment_system_managment.Models;

namespace Appointment_system_managment.Pages.patient_details
{
    public class DeleteModel : PageModel
    {
        private readonly Appointment_system_managment.Data.ASP _context;

        public DeleteModel(Appointment_system_managment.Data.ASP context)
        {
            _context = context;
        }

        [BindProperty]
        public patient_detail patient_detail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            patient_detail = await _context.patient_detail.FirstOrDefaultAsync(m => m.Id == id);

            if (patient_detail == null)
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

            patient_detail = await _context.patient_detail.FindAsync(id);

            if (patient_detail != null)
            {
                _context.patient_detail.Remove(patient_detail);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
