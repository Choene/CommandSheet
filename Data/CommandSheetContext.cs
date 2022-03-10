using CommandSheet.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandSheet.Data
{
    public class CommandSheetContext : DbContext
    {
        public CommandSheetContext(DbContextOptions<CommandSheetContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }
    }
}