using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Data_Access.DTOS
{
    public class CourseDTO
    {


        public int Id { get; set; }

        [Required(ErrorMessage = "Course Title is Required")]
        [MinLength(5)]
        [MaxLength(50)]
        public string CourseTitle { get; set; }

        [Required(ErrorMessage = "Course Description is Required")]
        [MinLength(5)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please add course level")]
        public int Level { get; set; }

        [Required(ErrorMessage = "Please add course price")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a price bigger than {1}")]
        public float FullPrice { get; set; }


    }
}
