using Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SubjectModel : BaseEntity
    {
        public string? SubjectName { get; set; }
        public int TotalMarks { get; set; }

    }
}
