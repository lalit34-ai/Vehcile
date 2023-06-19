// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Linq.Expressions;

// namespace VEHCILE.Repository.IRepository{
//     public interface IRepository<T> where T:class{
//         T GetFirstOrDefault(Expression<Func<T,bool>>filter);
//         IEnumerable<T> GetAllBikes();
//         IEnumerable<T> GetAllEmployees();
//         IEnumerable<T> GetAllBuses();
//         IEnumerable<T> GetAllDrivers();

//         // IEnumerable<T> Get
//         void Add(T entity);
//         void Remove(T entity);
//         void RemoveRange(IEnumerable<T> entity);
//     }
// }