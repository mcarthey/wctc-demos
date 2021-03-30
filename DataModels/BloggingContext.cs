using Microsoft.EntityFrameworkCore;

namespace EFPart1.DataModels
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        	// TODO - Change to use your database entry as below - Note it may be easiest to use the following for testing:
        	// "Server=(localdb)\MSSQLLocalDB;Database=Blogging;Integrated Security=True"
        	//
        	// Database=studentname_CRN_databasename
        	// User ID=studentname
        	// Password=studentid
        	// Example: mmcarthey_22097_Blogging
            optionsBuilder.UseSqlServer(
                @"Server=bitsql.wctc.edu;Database=studentname_CRN_databasename;User ID=studentname;Password=studentid");
        }
    }
}