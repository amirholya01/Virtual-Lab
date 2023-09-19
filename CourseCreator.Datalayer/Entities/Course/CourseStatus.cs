using System.ComponentModel.DataAnnotations;

namespace CourseCreator.Datalayer.Entities.Course;

public class CourseStatus
{
    [Key]
    public int StatusId { get; set; }
    
    [Required]
    [MaxLength(150)]
    public string StatusTitle { get; set; }


    public virtual ICollection<Course> Courses { get; set; }
}