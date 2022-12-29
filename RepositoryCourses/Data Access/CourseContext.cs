using Microsoft.EntityFrameworkCore;

using RepositoryCourses.Models;

namespace RepositoryCourses.Data_Access
{
    public class CourseContext:DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Cover> Covers { get; set; }
        public virtual DbSet<User> Users { get; set; }


    }


}
