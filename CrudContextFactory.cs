
using FunctionAppMYSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionAppMYSQL
{
    public class CrudContextFactory : IDesignTimeDbContextFactory<UserContext>
    {
       

        public UserContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UserContext>();
            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("SqlConnectionString"));

            return new UserContext(optionsBuilder.Options);
        }
    }
}
