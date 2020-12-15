﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Appointment_system_managment.Data;
using Appointment_system_managment.Models;

namespace Appointment_system_managment.Pages.Doctor_Details
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
            return Page();
        }

        [BindProperty]
        public doctor_detail doctor_detail { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.doctor_detail.Add(doctor_detail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
