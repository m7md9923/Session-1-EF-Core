using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo;

// Component based
// once u need package ==> install package manager console
// MyCompanyDbContext: Class when create obj from it ==> establish session with db [Open connection] 

internal class MyCompanyDbContext : DbContext
{
    public MyCompanyDbContext() : base()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=Test;Trusted_Connection=True; Trust server certificate=true;");
        
        // Connection with db ==> unmanage resources
        // Clr will open connection, but not close it 
    }
    public DbSet<Employee> Employees { get; set; }
    // Db Set --> access through Db Context 
    public DbSet<Department> Departments { get; set; }
    //public DbSet<Project> Projects { get; set; }
    public DbSet<Product> Products { get; set; }
    
}
