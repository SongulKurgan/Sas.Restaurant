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

namespace Sas.Restaurant.UI.BackOffice.Garson
{
    public partial class FrmGarson : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmGarson()
        {
            InitializeComponent();
            Listele();
        }
        void Listele()
        {
            worker.GarsonService.Load(null);
            gridControlGarson.DataSource = worker.GarsonService.BindingList();
        }
    }
}