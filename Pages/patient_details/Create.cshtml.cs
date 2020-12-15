﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Appointment_system_managment.Data;
using Appointment_system_managment.Models;

namespace Appointment_system_managment.Pages.patient_details
{
    public class CreateModel : PageModel
    {
        private readonly Appointment_system_managment.Data.ASP _context;

        public CreateModel(Appointment_system_managment.Data.ASP context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public patient_detail patient_detail { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.patient_detail.Add(patient_detail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
