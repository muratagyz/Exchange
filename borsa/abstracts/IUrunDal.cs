using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borsa.abstracts
{
    interface IUrunDal
    {
        void urunSatis(string _urunAdi, string _urunFiyati, string _urunMiktar, int _saticiId);
    }
}
