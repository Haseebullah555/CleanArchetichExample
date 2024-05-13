using Application.Contracts.Interfaces;
using Domain.Models;
using Persistence.Data;

namespace Persistence.Contracts.Implementations
{
    public class StudentRepository : GenericRepository<StudentModel>, IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
