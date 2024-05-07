using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Registeration
{
    public class RegisterDto 
    {
        [Required(ErrorMessage ="Student Name is required!")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Student Email is required!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Student Phone Number is required!")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        [DataType (DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirmed Password is required!")]
        [DataType (DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
