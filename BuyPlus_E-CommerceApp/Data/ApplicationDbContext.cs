using Microsoft.EntityFrameworkCore;

namespace BuyPlus_E_CommerceApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

    }
}
