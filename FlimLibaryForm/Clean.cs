using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlimLibaryForm
{
    public class Clean
    {
        public void Temizle(Control nesne)
        {
            foreach (Control item in nesne.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    tb.Clear();
                }
                if (item is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)item;
                    dtp.Value = DateTime.Now;
                }
            }
        }

        public void OzelTemizlik(Control[] temizlenecekYazılar, PictureBox nesne2)
        {
            for (int i = 0; i < temizlenecekYazılar.Length; i++)
            {
                temizlenecekYazılar[i].Text = "";
            }
            nesne2.ImageLocation = null;
        }
    }
}
