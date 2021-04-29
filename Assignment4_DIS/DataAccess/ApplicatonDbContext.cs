using Assignment4_DIS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using System.Configuration;

namespace Assignment4_DIS.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public Microsoft.EntityFrameworkCore.DbSet<ReviewRecord> Reviews { get; set; }

        public static string GetConnectionString()
        {
            //string constring = "Server = tcp:fuelstationssearch.database.windows.net,1433; Initial Catalog = FuelStation; Persist Security Info = False; User ID = disadmin; Password =Pnov1411#j; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
            //string constring = @"Server=(localdb)\mssqllocaldb;Database=Fuel_DB;Trusted_Connection=True;ConnectRetryCount=0";
            string constring = @"Server=tcp:fuelserver.database.windows.net,1433;Initial Catalog=fueldatabase;Persist Security Info=False;User ID=Testuser;Password=Test@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            return constring;
        }
    }
}
