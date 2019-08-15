using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlimLibaryForm
{
    public class Result
    {
        public void IslemKontrolu(bool sonuc)
        {
            if (sonuc)
            {
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.");
            }
        }
    }
}
