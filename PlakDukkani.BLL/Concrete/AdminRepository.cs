using PlakDukkani.Core.Interfaces;
using PlakDukkani.DAL;
using PlakDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.BLL.Concrete
{
    public class AdminRepository : IRepository<Admin>
    {
        PlakDukkaniContext db = new PlakDukkaniContext();
        public void Ekle(Admin item)
        {
            db.Admins.Add(item);
            db.SaveChanges();
        }

        public List<Admin> GetByAll()
        {
            return db.Admins.ToList();
        }

        public Admin GetByID(Guid id)
        {
            return db.Admins.Find(id);
        }

        public void Guncelle(Admin item)
        {
            db.Admins.Add(item);
            db.SaveChanges();
        }

        public void Sil(Admin item)
        {
            db.Admins.Remove(item);
            db.SaveChanges();
        }
    }
}
