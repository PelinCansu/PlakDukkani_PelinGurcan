using Microsoft.EntityFrameworkCore;
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
    public class AlbumRepository : IRepository<Album>
    {
        PlakDukkaniContext db = new PlakDukkaniContext();
        public void Ekle(Album item)
        {
            db.Albums.Add(item);
            db.SaveChanges();
        }

        public List<Album> GetByAll()
        {
            return db.Albums.ToList();

        }

        public Album GetByID(Guid id)
        {
            return db.Albums.Find(id);
        }

        public void Guncelle(Album item)
        {
            //db.Albums.Add(item);
            //db.SaveChanges();

            Guid _guncellenecekID = item.ID;
            db.Entry(db.Albums.Find(_guncellenecekID)).CurrentValues.SetValues(item);

            db.SaveChanges();
        }

        public void Sil(Album item)
        {
            //db.Albums.Remove(item);
            //db.SaveChanges();

            db.Entry(db.Albums.Find(item.ID)).State = EntityState.Deleted;

            db.SaveChanges();
        }
    }
}
