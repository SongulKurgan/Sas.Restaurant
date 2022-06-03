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

namespace Sas.Restaurant.UI.BackOffice.Fotograf
{
    public partial class FrmKamera : DevExpress.XtraEditors.XtraForm
    {
        public Image ReturnedImage;
        public FrmKamera()
        {
            InitializeComponent();
        }

        private void btnGoruntuAl_Click(object sender, EventArgs e)
        {
            picFoto.Image = Camera.TakeSnapshot();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            if (picFoto.Image!=null)
            {
                ReturnedImage = picFoto.Image;
                Close();
            }
            else
            {
                MessageBox.Show("Çekilen bir fotoğraf bulunamadı");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}