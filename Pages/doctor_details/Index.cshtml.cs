using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Appointment_system_managment.Data.ASM;
using Appointment_system_managment.Models;

namespace Appointment_system_managment.Pages.doctor_details
{
    public class IndexModel : PageModel
    {
        private readonly Appointment_system_managment.Data.ASM.database _context;

        public IndexModel(Appointment_system_managment.Data.ASM.database context)
        {
            _context = context;
        }

        public IList<doctor_detail> doctor_detail { get;set; }

        public async Task OnGetAsync()
        {
            doctor_detail = await _context.doctor_detail.ToListAsync();
        }
    }
}
