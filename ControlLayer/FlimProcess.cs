using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcsessLayer;
using EntityLayer;

namespace ControlLayer
{
    public class FlimProcess
    {
        public static bool controlToSaveFlim(Flimlerim f)
        {
            FlimRepository fr = new FlimRepository();
            if (fr.SaveData(f) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool controlToDeleteFlim(Flimlerim f)
        {
            FlimRepository fr = new FlimRepository();
            if (fr.DeleteData(f)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool controlToUpdateFlim(Flimlerim f)
        {
            FlimRepository fr = new FlimRepository();
            if (fr.UpdateData(f) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
