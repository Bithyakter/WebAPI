using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// <summary>
    /// Contains signature of all generic methods.
    /// </summary>
    /// <typeparam name="T">T is a model class.</typeparam>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Searches using Id.
        /// </summary>
        /// <param name="id">id of the table.</param>
        /// <returns>Retrieved row in the form of model object.</returns>
        T GetById(int id);

        /// <summary>
        /// Loads all rows from the database table.
        /// </summary>
        /// <returns>Object list.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        ///  Searches using the given criteria.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>Object list.</returns>
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Inserts information available in the given object.
        /// </summary>
        /// <param name="entity">Object name.</param>
        /// <returns>Inserted object.</returns>
        void Add(T entity);

        /// <summary>
        /// Inserts List of information available in the given object.
        /// </summary>
        /// <param name="entities"></param>
        void AddList(IEnumerable<T> entities);

        /// <summary>
        /// Deletes the given object.
        /// </summary>
        /// <param name="entity">Object to be removed.</param>
        void Remove(T entity);

        /// <summary>
        /// Deletes the given object.
        /// </summary>
        /// <param name="entities">List of Object to be removed.</param>
        void RemoveList(IEnumerable<T> entities);
    }
}
