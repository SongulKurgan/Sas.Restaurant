using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.UI.BackOffice.Urun
{
    public partial class FrmUrunIslem : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrunIslem()
        {
            InitializeComponent();
        }

        private void controlMenuKayit1_EkleClick_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ekleye tıklandı");
        }
    }
}