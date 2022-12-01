namespace Attendance_ManagementV1._0.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProjDbContext : DbContext
    {
      
        public ProjDbContext()
            : base("name=ProjDbContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        //public DbSet<login> Logins { get; set; }
        public DbSet<StudentFaculty> StudentFaculties { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<FacultyDivision> FacultyDivisions { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<FacultyCourse> FacultyCourses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<StudentAttendance> StudentAttendances {get; set;}
        public DbSet<DivisionCourse>DivisionCourses { get; set; }
      

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}