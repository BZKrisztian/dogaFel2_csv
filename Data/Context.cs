using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Insert Correct string here");
        }

    }
}