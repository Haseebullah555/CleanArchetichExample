using Application.Contracts.Interfaces;
using Domain.Models;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contracts.Implementations
{
    public class SubjectRepository : GenericRepository<SubjectModel>, ISubjectRepository
    {
        public SubjectRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
