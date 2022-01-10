using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.Repositories
{
    public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        /// <summary>
        /// Implements GenericRepository class & IDeveloperRepository interface.
        /// </summary>
        public DeveloperRepository(ApplicationContext context) : base(context)
        {

        }

        /// <summary>
        /// Implements IRepository Interface.
        /// </summary>
        /// <param name="count">developers list</param>
        /// <returns>int type</returns>
        public IEnumerable<Developer> GetPopularDevelopers(int count)
        {
            return _context.developers.OrderByDescending(d => d.Followers).Take(count).ToList();
        }
    }
}
