using CourseCreator.Datalayer.Entities.Course;
using CourseCreator.Datalayer.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace CourseCreator.Datalayer.Context;

public class CourseCreatorContext : DbContext
{
    public CourseCreatorContext(DbContextOptions<CourseCreatorContext>options):base(options)
    {
        
    }
    
    #region User
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> userRoles { get; set; }
    #endregion

    #region Course

    public DbSet<CourseGroup> CourseGroups { get; set; }

    public DbSet<Course> Courses { get; set; }

    public DbSet<CourseEpisode> CourseEpisodes { get; set; }

    public DbSet<CourseLevel> CourseLevels { get; set; }

    public DbSet<CourseStatus> CourseStatus { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CourseGroup>()
            .HasQueryFilter(g => !g.IsDelete);

      /*  modelBuilder.Entity<Course>()
            .Property(c => c.CourseStatus)
            .HasConversion<string>();

        modelBuilder.Entity<Course>()
            .Property(c => c.CourseLevel)
            .HasConversion<string>();*/
        
       
        base.OnModelCreating(modelBuilder);
    }
}