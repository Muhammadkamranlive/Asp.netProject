using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Data_Access.DTOS
{
    public class CoverDTO
    {

        [Required]
        public string CoverTitle { get; set; }
       
    }
}
