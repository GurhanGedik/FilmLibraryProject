using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAcsessLayer
{
    public class FlimRepository:IRepository
    {
        public static FilmLibraryProjectEntities con = Connection.MyDB();

        public List<Flimlerim> GetAll()
        {
            return con.Flimlerims.ToList();
        }

        public int SaveData(object kaydet)
        {
            Flimlerim f = (Flimlerim)kaydet;
            con.Flimlerims.Add(f);
            return con.SaveChanges();
        }

        public int DeleteData(object sil)
        {
            Flimlerim f = (Flimlerim)sil;
            Flimlerim delete = con.Flimlerims.SingleOrDefault(x => x.FlimID == f.FlimID);
            con.Flimlerims.Remove(f);
            return con.SaveChanges();
        }

        public int UpdateData(object guncelle)
        {
            Flimlerim f = (Flimlerim)guncelle;
            Flimlerim update = con.Flimlerims.SingleOrDefault(x => x.FlimID == f.FlimID);
            return con.SaveChanges();
        }
    }
}
