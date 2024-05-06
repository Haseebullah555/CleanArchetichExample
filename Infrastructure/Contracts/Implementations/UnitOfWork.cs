using Application.Contracts.Interfaces;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contracts.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IStudentRepository _studentRepository;
        private ISubjectRepository _subjectRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
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
