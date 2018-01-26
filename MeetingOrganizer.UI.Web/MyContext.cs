using MeetingOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MeetingOrganizer.DAL
{
    public class MyContext:DbContext
    {
        public MyContext() : base("name=MyCon") { }
       
        public virtual DbSet<Toplanti> Toplantilar { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
