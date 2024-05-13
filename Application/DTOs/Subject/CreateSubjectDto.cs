using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Subject
{
    public class CreateSubjectDto
    {
        public string? SubjectName { get; set; }
        public int TotalMarks { get; set; }
    }
}
