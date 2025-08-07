using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GroupProject.Data;
using GroupProject.Models;

namespace GroupProject.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly GroupProject.Data.ApplicationDbContext _context;

        public DetailsModel(GroupProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.Email == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
