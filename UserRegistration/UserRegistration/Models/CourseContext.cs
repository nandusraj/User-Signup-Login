using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistration.Models
{
    public class CourseContext:DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options):base(options)
        {

        }
        public DbSet<CourseModel> CourseModels { get; set; }
        public DbSet<CartModel> CartModels  { get; set; }
    }
}
