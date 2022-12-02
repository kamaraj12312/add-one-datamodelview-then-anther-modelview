using Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Models.viewmodelDBcontext
{
    public class ViewmodelDBcontext :DbContext
    {
        public ViewmodelDBcontext():base("name=ViewmodelDBcontext")
        {

        }
        public ViewmodelDBcontext(string ConnectionString) :base(ConnectionString)
        {

        }
        public virtual DbSet<HolidaySetup> HolidaySetups { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HolidaySetup>().ToTable("HolidaySetup", "Tenant2");
        }
    }
}
    