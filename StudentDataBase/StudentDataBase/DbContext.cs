using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace StudentDataBase
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
