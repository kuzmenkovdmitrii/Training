using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Common.Entities;
using DAL.Context;
using DAL.Repository.Interface;

namespace DAL.Repository
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

        public void Create(User item)
        {
            db.Users.Add(item);
            Save();
        }

        public void Update(User item)
        {
            User user = db.Users.Find(item.Id);

            db.Entry(user).CurrentValues.SetValues(item);
            db.Entry(user).State = EntityState.Modified;

            Save();
        }

        public void Delete(int id)
        {
            User user = db.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                db.Users.Remove(user);
            }
            Save();
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
