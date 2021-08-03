using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepositorio
    {
        #region 'CREATE'

        T Create<T>(T obj) where T : class;
        Task<T> CreateAsync<T>(T obj) where T : class;
        IEnumerable<T> AddRange<T>(IEnumerable<T> obj) where T : class;
        Task<IEnumerable<T>> AddRangeAsync<T>(IEnumerable<T> obj) where T : class;
        #endregion
        #region 'READ'
        IEnumerable<T> Read<T>() where T : class;
        Task<IEnumerable<T>> ReadAsync<T>() where T : class;
        Boolean Exist<T>(Expression<Func<T, bool>> matchitem) where T : class;
        Task<Boolean> ExistAsync<T>(Expression<Func<T, bool>> matchitem) where T : class;
        T Find<T>(Expression<Func<T, bool>> matchitem) where T : class; /*Single Item*/
        Task<T> FindAsync<T>(Expression<Func<T, bool>> matchitem) where T : class;
        T FindInclude<T>(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria) where T : class;
        Task<T> FindIncludeAsync<T>(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria) where T : class;
        IEnumerable<T> FindAll<T>(Expression<Func<T, bool>> matchitem) where T : class; /*Many Items*/
        IEnumerable<T> FindAllInclude<T>(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria) where T : class;/*Include Relationship of T*/
        Task<IEnumerable<T>> FindAllIncludeAsync<T>(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria) where T : class; /*Include Relationship of T*/
        Task<IEnumerable<T>> FindAllAsync<T>(Expression<Func<T, bool>> matchitem) where T : class;
        IEnumerable<T> FindAllWhere<T>(Expression<Func<T, bool>> matchitem) where T : class;
        Task<IEnumerable<T>> FindAllWhereAsync<T>(Expression<Func<T, bool>> matchitem) where T : class;
        IEnumerable<T> FindAllWhereTake<T>(Expression<Func<T, bool>> matchitem, int count) where T : class;
        Task<IEnumerable<T>> FindAllWhereTakeAsync<T>(Expression<Func<T, bool>> matchitem, int count) where T : class;
        IEnumerable<T> FindAllTake<T>(int count) where T : class;
        Task<IEnumerable<T>> FindAllTakeAsync<T>(int count) where T : class;
        T Get<T>(int id) where T : class;
        Task<T> GetAsync<T>(int id) where T : class;
        #endregion
        #region 'UPDATE'
        T Update<T>(T obj) where T : class;

        T Update2<T>(T obj) where T : class;
        //Task<T> UpdateAsync<T>(T obj) where T : class;
        #endregion
        #region 'DELETE'
        T Delete<T>(T obj) where T : class;
        //Task<T> DeleteAsync<T>(T obj) where T : class;
        IEnumerable<T> DeleteRange<T>(IEnumerable<T> obj) where T : class;
        Task<IEnumerable<T>> DeleteRangeAsync<T>(IEnumerable<T> obj) where T : class;

        void DeletaAllRows<T>() where T : class;
        #endregion
            #region 'COUNT'
        int Count<T>() where T : class;
        Task<int> CountAsync<T>() where T : class;
        #endregion
        #region 'EXISTS'
        Boolean Exists<T>(Expression<Func<T, bool>> matchitem) where T : class;
        Task<Boolean> ExistsAsync<T>(Expression<Func<T, bool>> matchitem) where T : class;
        #endregion
        IQueryable<T> FindAllQuarable<T>() where T : class;
    }
}