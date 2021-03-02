using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClientCRUD.Data;
using ClientCRUD.Models;

namespace ClientCRUD.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly ClientCRUD.Data.ClientCRUDContext _context;

        public DetailsModel(ClientCRUD.Data.ClientCRUDContext context)
        {
            _context = context;
        }

        public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Client.FirstOrDefaultAsync(m => m.name == id);

            if (Client == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
