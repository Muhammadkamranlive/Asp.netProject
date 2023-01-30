using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Data_Access.DTOS
{
    public class CoverDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Course Cover title is Required")]
        [MinLength(1)]
        [MaxLength(20)]
        public string CoverTitle { get; set; }

    }
}
