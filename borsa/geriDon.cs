using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borsa
{
    public class geriDon
    {
        public void geriGel()
        {
            secimEkrani sc = new secimEkrani();
            sc.Show();
            this.Hide();
        }

        private void Hide()
        {
            throw new NotImplementedException();
        }
    }
}
