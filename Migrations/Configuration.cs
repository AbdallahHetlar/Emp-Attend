namespace Attendance_ManagementV1._0.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Attendance_ManagementV1._0.Models.ProjDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Attendance_ManagementV1._0.Models.ProjDbContext context)
        {
           

            //context.People.AddOrUpdate(
            //  p => p.FullName,
            //  new Person { FullName = "HUSSEIN" };
             

        }
    }
}
