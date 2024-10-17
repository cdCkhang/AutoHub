using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class DataAccess:DbContext
    {
        //  Replace this with your actual SQL Server's Connection String.
        string connection = @"Data Source=KHANGLAPTOP;Initial Catalog=ProjectcnDotNet_CDM;Integrated Security=True;Trust Server Certificate=True";
        public DbSet<Account> DSAccount { get; set; }
        public DbSet<Car> DSCar { get; set; }
        public DbSet<Customer> DSCustomer { get; set; }
        public DbSet<Manufacturer> DSManu { get; set; }
        public DbSet<Saler> DSSaler { get; set; }
        public DbSet<Transaction> DSTrans {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }

        
    }
}