using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BroadWayWebProject.Data
{
    public class DBConfiguration : DbContext
    {
        public DBConfiguration(): base("name = MVCWebAppContext")
        {
        }

        public virtual DbSet<Models.Login> Logins { get; set; }
        public virtual DbSet<Models.Account> Accounts { get; set; }
    }
}