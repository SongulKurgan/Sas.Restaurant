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

namespace Sas.Restaurant.UserControls
{
    public partial class ControlAnaMenuAlt : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler ButtonEkle;
        public event EventHandler ButtonDuzenle;
        public event EventHandler ButtonSil;
        public event EventHandler ButtonGuncelle;
        public event EventHandler ButtonKapat;
        private Font _buttonFont = new Font("Tahoma", 8, FontStyle.Bold);
        public Font ButtonFont
        {
            get
            {
                return _buttonFont;
            }
            set
            {
                btnEkle.Font = value;
                btnDüzenle.Font = value;
                btnSil.Font = value;
                btnGüncelle.Font = value;
                btnKapat.Font = value;
                _buttonFont = value;
            }

        }

        public ControlAnaMenuAlt()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ButtonEkle?.Invoke(this, e);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            ButtonDuzenle?.Invoke(this, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ButtonSil?.Invoke(this, e);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ButtonGuncelle?.Invoke(this, e);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            ButtonKapat?.Invoke(this, e);
        }
    }
}
