using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET.Models.EntityFramework
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Folder> Folders { get; set; }

        #region Constructors 

        public ApplicationContext() : base("DefaultConnection") { }

        static ApplicationContext()
        {
            Database.SetInitializer<ApplicationContext>(new ContextInitializer());

        }

        #endregion

    }
}