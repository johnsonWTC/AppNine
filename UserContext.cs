using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppNine
{
   public class UserContext : DbContext
    {
        public UserContext() { }
        public UserContext(DbContextOptions<UserContext> options)
         : base(options)
        { }

        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { // //   "SqlConnectionString": "server=localhost; port=3306; database=test; user=Jamgod; password=Jamgod12345!!!!!; Persist Security Info=False; Connect Timeout=300"  
          //   $env: SqlConnectionString = "Data Source=ASSET-10422\SQLEXPRESS;Initial Catalog=FunctionCrud010;Integrated Security=True"
            // $env:SqlConnectionString= "server=localhost; port=3306; database=test; user=Jamgod; password=Jamgod12345!!!!!; Persist Security Info=False; Connect Timeout=300" 
        //    optionsBuilder.UseMySql("server=localhost; port=3306; database=AppNine; user=JamGod; password=Jamgod12345!!!!!; Persist Security Info=False; Connect Timeout=300");
        }


    }
}
