using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borsa.abstracts
{
    public interface ILoginDal
    {
        void kontrol(string tabloAdi, string id, string sifre, string textBoxKullaniciAd, string textBoxSifre);
        string onayliMi(string txtkAd, string tblAd);
    }
}
