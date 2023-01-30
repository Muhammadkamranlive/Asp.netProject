using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Data_Access.DTOS
{
    public class TagDTO
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Tag Name is Required")]
        [MinLength(1)]
        [MaxLength(20)]
        public string Title { get; set; }

    }
}
