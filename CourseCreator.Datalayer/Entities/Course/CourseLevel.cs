using System.ComponentModel.DataAnnotations;

namespace CourseCreator.Datalayer.Entities.Course;

public class CourseLevel
{
    [Key]
    public int LevelId { get; set; }

    [MaxLength(150)]
    [Required]
    public string LevelTitle { get; set; }


    public virtual ICollection<Course> Courses { get; set; }
}