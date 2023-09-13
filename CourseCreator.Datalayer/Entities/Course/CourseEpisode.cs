using System.ComponentModel.DataAnnotations;

namespace CourseCreator.Datalayer.Entities.Course;

public class CourseEpisode
{
    [Key]
    public int EpisodeId { get; set; }

    [Display(Name = "episode")]
    [Required(ErrorMessage = "The {0} must not be empty.")]
    [MaxLength(400, ErrorMessage = "The {0} can not be more than {1} characters.")]
    public string EpisodeTitle { get; set; }

    [Display(Name = "time of episode")]
    [Required(ErrorMessage = "The {0} must not be empty.")]
    public TimeSpan EpisodeTime { get; set; }

    [Display(Name = "file name of episode")]
    public string EpisodeFileName { get; set; }


    #region Relation

    public Course Course { get; set; }
    
    #endregion
}