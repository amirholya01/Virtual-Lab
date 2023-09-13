using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseCreator.Datalayer.Entities.Course;

public class CourseGroup
{
    [Key]
    public int GroupId { get; set; }
    
    [Display(Name = "title of group")]
    [Required(ErrorMessage = "The {0} must not be empty.")]
    [MaxLength(200, ErrorMessage = "The {0} can not be more than {1} characters.")]
    public string GroupTitle { get; set; }
    
    [Display(Name = "Is delete?")]
    public bool IsDelete { get; set; }
    
    [Display(Name = "main group")]
    public int? ParentId { get; set; }

    [ForeignKey("ParentId")]
    public ICollection<CourseGroup> CourseGroups { get; set; }
    
}