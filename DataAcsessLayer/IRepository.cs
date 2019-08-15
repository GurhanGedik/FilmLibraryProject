using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAcsessLayer
{
    interface IRepository
    {
        List<Flimlerim> GetAll();
        int SaveData(object kaydet);
        int DeleteData(object sil);
        int UpdateData(object guncelle);
    }
}
