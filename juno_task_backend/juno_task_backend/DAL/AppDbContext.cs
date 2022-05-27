using Microsoft.EntityFrameworkCore;

namespace juno_task_backend.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
