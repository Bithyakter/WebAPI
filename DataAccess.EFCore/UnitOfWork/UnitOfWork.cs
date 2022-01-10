using DataAccess.EFCore.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.UnitOfWork
{
    /// <summary>
    /// Implementation of UnitOfWork
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Developers = new DeveloperRepository(_context);
            Projects = new ProjectRepository(_context);
        }

        public IDeveloperRepository Developers { get; private set; }
        public IProjectRepository Projects { get; private set; }

        #region Complete Method
        public int Complete()
        {
            return _context.SaveChanges();
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion
    }
}
