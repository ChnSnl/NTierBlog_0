using Project.BLL.DesignPatterns.GenericRepository.IntRepository;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Project.Entities.Enums;

namespace Project.BLL.DesignPatterns.GenericRepository.EFBaseRepository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected MyContext _db;

        public BaseRepository()
        {
            _db = DBTool.DbInstance;
        }

        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            Save();
        }

        protected void Save()
        {
            _db.SaveChanges();
        }

        public void AddRange(List<T> list)
        {
            _db.Set<T>().AddRange(list);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.Status = DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            Save();
        }

        public void DeleteRange(List<T> list)
        {
            foreach (T item in list) Delete(item);

        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item);
            Save();
        }

        public void DestroyRange(List<T> list)
        {
           _db.Set<T>().RemoveRange(list);
            Save() ;
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
            
        }

        public List<T> GetDatas(int count)
        {
            return _db.Set<T>().Take(count).ToList();
        }

        public List<T> GetDeleteds()
        {
            return Where(x => x.Status == DataStatus.Deleted);
        }

        public List<T> GetFirstDatas(int count)
        {
            return _db.Set<T>().OrderBy(x => x.CreatedDate).Take(count).ToList();
        }

        public List<T> GetLastDatas(int count)
        {
            return _db.Set<T>().OrderByDescending(x => x.CreatedDate).Take(count).ToList();
        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == DataStatus.Updated);
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _db.Set<T>().Select(exp).ToList();
        }

        public List<MyModel> SelectVia<MyModel>(Expression<Func<T, MyModel>> exp) where MyModel : class
        {
            return _db.Set<T>().Select(exp).ToList();
        }

        public void Update(T item)
        {
            item.Status = DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;

            T originalData = Find(item.ID);
            _db.Entry(originalData).CurrentValues.SetValues(item);
            Save();              
            
        }

        public void UpdateRange(List<T> list)
        {
            foreach (T item in list) Update(item);

        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
