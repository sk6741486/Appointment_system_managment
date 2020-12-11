﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Appointment_system_managment.Data.ASM;
using Appointment_system_managment.Models;

namespace Appointment_system_managment.Pages.appointments
{
    public class EditModel : PageModel
    {
        private readonly Appointment_system_managment.Data.ASM.database _context;

        public EditModel(Appointment_system_managment.Data.ASM.database context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(appointment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!appointmentExists(appointment.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool appointmentExists(int id)
        {
            return _context.appointment.Any(e => e.ID == id);
        }
    }
}
