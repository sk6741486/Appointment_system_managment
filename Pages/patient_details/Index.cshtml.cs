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
    public class IndexModel : PageModel
    {
        private readonly Appointment_system_managment.Data.ASP _context;

        public IndexModel(Appointment_system_managment.Data.ASP context)
        {
            _context = context;
        }

        public IList<patient_detail> patient_detail { get;set; }

        public async Task OnGetAsync()
        {
            patient_detail = await _context.patient_detail.ToListAsync();
        }
    }
}
