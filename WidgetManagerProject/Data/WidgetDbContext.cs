using Microsoft.EntityFrameworkCore;
using WidgetManagerProject.Models;
namespace WidgetManagerProject.Data
{
    public class WidgetDbContext: DbContext
    {
        public WidgetDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Widget> Widgets { get; set; }
    }

}
