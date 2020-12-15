using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Appointment_system_managment.Data;
using Appointment_system_managment.Models;

namespace Appointment_system_managment.Pages.Appointments
{
    public class CreateModel : PageModel
    {
        private readonly Appointment_system_managment.Data.Appointment_system_managment_Database _context;

        public CreateModel(Appointment_system_managment.Data.Appointment_system_managment_Database context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Doctor_DetailID"] = new SelectList(_context.doctor_detail, "Id", "Email");
        ViewData["Patient_DetailID"] = new SelectList(_context.patient_detail, "Id", "Name");
        ViewData["ClinicId"] = new SelectList(_context.clinic, "Id", "Clinic_address");
            return Page();
        }

        [BindProperty]
        public appointment appointment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.appointment.Add(appointment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
