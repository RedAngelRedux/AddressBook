using AddressBook.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public DbSet<Contact> Contacts { get; set; }
    }


}
