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
    public class IndexModel : PageModel
    {
        private readonly ClientCRUD.Data.ClientCRUDContext _context;

        public IndexModel(ClientCRUD.Data.ClientCRUDContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; }

        public async Task OnGetAsync()
        {
            Client = await _context.Client.ToListAsync();
        }
    }
}
