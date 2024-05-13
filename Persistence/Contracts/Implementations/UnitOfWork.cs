using Application.Contracts.Interfaces;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contracts.Implementations
{
    public class UnitOfWork(ApplicationDbContext context) : IUnitOfWork
    {
        private readonly ApplicationDbContext _context = context;
        private IStudentRepository? _studentRepository;
        private ISubjectRepository? _subjectRepository;

        public IStudentRepository StudentRepository =>
          _studentRepository ??= new StudentRepository(_context);
        public ISubjectRepository SubjectRepository =>
            _subjectRepository ??= new SubjectRepository(_context);
        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
