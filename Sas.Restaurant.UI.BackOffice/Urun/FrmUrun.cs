using DevExpress.XtraEditors;
using Sas.Restaurant.Business.Workers;
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
    public partial class FrmUrun : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmUrun()
        {
            InitializeComponent();
            gridControlUrunler.DataSource = worker.UrunService.GetList(null, c => c.UrunGrup);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmUrunIslem form = new FrmUrunIslem(new Entites.Tables.Urun());
            form.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmUrunIslem form = new FrmUrunIslem((Entites.Tables.Urun)gridUrunler.GetFocusedRow());
            form.ShowDialog();
        }
    }
}