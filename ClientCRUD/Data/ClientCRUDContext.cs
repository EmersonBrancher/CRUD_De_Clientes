using Microsoft.EntityFrameworkCore;

namespace ClientCRUD.Data
{
    public class ClientCRUDContext : DbContext
    {
        public ClientCRUDContext (
            DbContextOptions<ClientCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<ClientCRUD.Models.Client> Client { get; set; }
    }
}