using Microsoft.EntityFrameworkCore;

namespace API___დამოუკიდებლად.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options) {  }

        public DbSet<Person> PersonTbl { get; set; }
    }
}
