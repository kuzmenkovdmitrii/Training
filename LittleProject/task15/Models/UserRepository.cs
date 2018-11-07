using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace task15.Models
{
    public interface IRepository : IDisposable
    {
        IEnumerable<User> List();
        User Get(int id);

        void Create(User user);
        void Update(User user);
        void Delete(int id);
        void Save();
    }

    public class UserRepository : IRepository
    {
        UserContext db = new UserContext();

        //public void Save(User user)
        //{
        //    db.Users.Create(user);
        //    db.SaveChanges();
        //}

        public IEnumerable<User> List()
        {
            return db.Users;
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}