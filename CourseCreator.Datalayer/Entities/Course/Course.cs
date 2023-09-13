using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CourseCreator.Datalayer.Entities.Enums;

namespace CourseCreator.Datalayer.Entities.Course;

public class Course
{
    [Key]
    public int CourseId { get; set; }

    [Required]
    public int GroupId { get; set; }

    public int? SubGroup { get; set; }

    public CourseStatus CourseStatus { get; set; }

    public CourseLevel CourseLevel { get; set; }
    
    [Required]
    public int TeacherId { get; set; }
    
    [Display(Name = "title of course")]
    [Required(ErrorMessage = "The {0} must not be empty.")]
    [MaxLength(450, ErrorMessage = "The {0} can not be more than {1} characters.")]
    public string CourseTitle { get; set; }

    
    [Display(Name = "description of course")]
    [Required(ErrorMessage = "The {0} must not be empty.")]
    public string Description { get; set; }
    
    [MaxLength(50, ErrorMessage = "The image name can not be more than 50 characters.")]
    public string CourseImageName { get; set; }

    [Required]
    public DateTime CreateDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    [MaxLength(100, ErrorMessage = "The name's file of demo can not be more than 100 characters.")]
    public string DemoFileName { get; set; }

    #region Relation

    [ForeignKey("TeacherId")]
    public virtual User.User User { get; set; }
    
    [ForeignKey("GroupId")]
    public virtual CourseGroup CourseGroup { get; set; }
    
    [ForeignKey("SubGroup")]
    public virtual CourseGroup Group { get; set; }

    public virtual ICollection<CourseEpisode> CourseEpisodes { get; set; }
    #endregion

   
    
}