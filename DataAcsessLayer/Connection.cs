using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;


namespace DataAcsessLayer
{
    public class Connection
    {
        private static FilmLibraryProjectEntities _db = null;
        public static FilmLibraryProjectEntities MyDB()
        {
            if (_db == null)
            {
                _db = new FilmLibraryProjectEntities();
            }
            return _db;
        }
    }
}
