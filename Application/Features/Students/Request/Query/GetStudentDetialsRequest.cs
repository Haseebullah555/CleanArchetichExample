﻿using Application.DTOs.Student;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Request.Query
{
    public class GetStudentDetialsRequest : IRequest<StudentDto>
    {
        public int Id { get; set; }
    }
}
