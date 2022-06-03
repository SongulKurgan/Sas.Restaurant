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
    public partial class FrmImageEditor : DevExpress.XtraEditors.XtraForm
    {
        public Image ReturnedImage;
        public FrmImageEditor()
        {
            InitializeComponent();
            lblCerceve.Draggable(true);
            lblCerceve.Parent = picFoto;
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            XtraOpenFileDialog dialog = new XtraOpenFileDialog();

            dialog.Filter = "JPG Dosyası (*.jpg)|*.jpg|BMP Dosyası (*.bmp)|*.bmp|PNG Dosyası (*.png)|*.png";
            dialog.FilterIndex = 2;
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(dialog.FileName);
                lblCerceve.Visible = true;
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            if (picFoto.Image==null)
            {
                MessageBox.Show("Bir Fotoğraf Seçilmedi");
                return;
            }
            ReturnedImage = CroppedImage();
            Close();
        }
        private Image CroppedImage()
        {
            Image croppedImage = new Bitmap(GetZoomedImage(picFoto),picFoto.ClientSize);
            Rectangle rect = new Rectangle(lblCerceve.Location.X,lblCerceve.Location.Y,lblCerceve.Width,lblCerceve.Height);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(croppedImage,new Rectangle(0,0,lblCerceve.Width,lblCerceve.Height),lblCerceve.Left,lblCerceve.Top,lblCerceve.Width,lblCerceve.Height,GraphicsUnit.Pixel);
            return bmp;
        }
        private Image GetZoomedImage(PictureEdit sourcePicture)
        {
            lblCerceve.Visible = false;
            Bitmap bmp = new Bitmap(sourcePicture.Width,sourcePicture.Height);
            sourcePicture.DrawToBitmap(bmp,sourcePicture.Bounds);
            return bmp;
        }

        private void zoomTrackBarControl1_ValueChanged(object sender, EventArgs e)
        {
            picFoto.Properties.ZoomPercent = zoomTrackBarControl1.Value;
            txtZoom.Value = zoomTrackBarControl1.Value;
        }

        private void txtZoom_EditValueChanged(object sender, EventArgs e)
        {
            zoomTrackBarControl1.Value = Convert.ToInt32(txtZoom.Value);
        }

        private void picFoto_ZoomPercentChanged(object sender, EventArgs e)
        {
            zoomTrackBarControl1.Value = Convert.ToInt32(picFoto.Properties.ZoomPercent);
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            picFoto.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKamera_Click(object sender, EventArgs e)
        {
            FrmKamera form = new FrmKamera();
            form.ShowDialog();
            if (form.ReturnedImage!=null)
            {
                picFoto.Image = form.ReturnedImage;
                picFoto.Properties.ZoomPercent = 100;
                zoomTrackBarControl1.Value = 100;
                txtZoom.Value = 100;
            }
        }
    }
}