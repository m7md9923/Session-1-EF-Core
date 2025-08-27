using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        #region Demo

        // More than one DbContext ==> connect more than one DB
        // APIS ==> Connects 2 DB ==> Identity [UserInfo-Roles] -- Business
        // IndentityDbContext, BusinessDbContext
        // Class DbContext must end with keyword DbContext
        // DbContext ==> CompanyDbContext 
        
        MyCompanyDbContext dbContext = new();
        
        // Old way 
        
        // try
        // {
        //     // Some Code
        //     
        // }
        // finally  // keda keda excuted even if exception happened
        // {
        //     dbContext.Dispose(); // Close connection
        // }

        // old
        
        // using (dbContext)
        // {
        //     // Some Code
        //     
        // }


        //using (dbContext);  // most common used 
        // Some Code
        // dbContext.Database.Migrate();
        
        
        
        
        
        


        #endregion
    }
    
}