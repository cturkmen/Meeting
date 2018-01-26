using MeetingOrganizer.DAL;
using MeetingOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MeetingOrganizer.UI.Web.Repo
{
    public class RepoBase
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