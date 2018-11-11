using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using task15.Context;
using task15.Models;

namespace task15.Repository
{
    public class UserRepository : IUserRepository
    {
        ApplicationContext db = new ApplicationContext();

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
            Save();
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            User user = db.Users.FirstOrDefault(x=>x.Id == id);
            if (user != null)
            {
                db.Users.Remove(user);
                Save();
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