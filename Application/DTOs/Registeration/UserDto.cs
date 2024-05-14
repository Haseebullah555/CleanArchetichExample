using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Registeration
{
    public class UserDto : BaseDto
    {
        [Required(ErrorMessage ="Student Name is required!")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Student Email is required!")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Student Phone Number is required!")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        [DataType (DataType.Password)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Confirmed Password is required!")]
        [DataType (DataType.Password)]
        [Compare("Password", ErrorMessage ="Password and Confirm password do not match")]
        public string? ConfirmPassword { get; set; }
    }
}
