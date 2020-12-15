﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Appointment_system_managment.Data;
using Appointment_system_managment.Models;

namespace Appointment_system_managment.Pages.Doctor_Details
{
    public class DetailsModel : PageModel
    {
        private readonly Appointment_system_managment.Data.Appointment_system_managment_Database _context;

        public DetailsModel(Appointment_system_managment.Data.Appointment_system_managment_Database context)
        {
            _context = context;
        }

        public doctor_detail doctor_detail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            doctor_detail = await _context.doctor_detail.FirstOrDefaultAsync(m => m.Id == id);

            if (doctor_detail == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
