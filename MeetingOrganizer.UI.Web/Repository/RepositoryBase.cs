using System;
using System.Collections.Generic;
using System.Linq;
using MeetingOrganizer.DAL;
using MeetingOrganizer.Models;
using System.Data.Entity;

namespace MeetingOrganizer.BLL.Repository
{
    //public abstract class RepositoryBase<T, ID> where T : class
    //{
    //    protected internal static MyContext dbContext;

    //    public virtual List<T> GetAll()
    //    {
    //        dbContext = new MyContext();
    //        return dbContext.Set<T>().ToList();
    //    }

    //    public virtual T GetByID(ID id)
    //    {
    //        dbContext = new MyContext();
    //        return dbContext.Set<T>().Find(id);
    //    }

    //    public virtual void Insert(T entity)
    //    {
    //        try
    //        {
    //            dbContext = dbContext ?? new MyContext();
    //            dbContext.Set<T>().Add(entity);
    //            dbContext.SaveChanges();
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //    }

    //    public virtual void Delete(T entity)
    //    {
    //        try
    //        {
    //            dbContext = dbContext ?? new MyContext();
    //            dbContext.Set<T>().Remove(entity);
    //            dbContext.SaveChanges();
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //    }

    //    public virtual void Update()
    //    {
    //        try
    //        {
    //            dbContext.SaveChanges();
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //    }
    //}

    public class Repository
    {
        private readonly MyContext _context = new MyContext();

        public void Create(Toplanti toplanti)
        {
            _context.Toplantilar.Add(toplanti);
            _context.SaveChanges();
        }

        public void Update(Toplanti toplanti)
        {
            _context.Entry(toplanti).State = EntityState.Modified;
            _context.Entry(toplanti).Property(model => model.OlusturulmaTarihi).IsModified = false;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var appointment = FindById(id);
            _context.Toplantilar.Remove(appointment);
            _context.SaveChanges();
        }

        public Toplanti FindById(int id)
        {
            return _context.Toplantilar.Find(id);
        }

        public IEnumerable<Toplanti> FindAll()
        {
            return _context.Toplantilar.ToList();
        }
    }
}
