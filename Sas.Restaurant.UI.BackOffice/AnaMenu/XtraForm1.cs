using DevExpress.XtraEditors;
using Sas.Restaurant.Components.CallerId;
using Sas.Restaurant.UI.BackOffice.Musteri;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.UI.BackOffice.AnaMenu
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            controlBadgButton1.Count++;
        }
    }
}