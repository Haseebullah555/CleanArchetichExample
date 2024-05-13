using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Student
{
    public class CreateStudentDto
    {
        [Required(ErrorMessage = "First Name is Required")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Grade is Required")]
        public string? Grade { get; set; }
    }
}
