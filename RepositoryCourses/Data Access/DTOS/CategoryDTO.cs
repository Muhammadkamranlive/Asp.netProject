using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Data_Access.DTOS
{
    public class CategoryDTO
    {

        [Required(ErrorMessage = "Category Name is Required")]
        [MinLength(1)]
        [MaxLength(20)]
        public string Name { get; set; }

    }
}
