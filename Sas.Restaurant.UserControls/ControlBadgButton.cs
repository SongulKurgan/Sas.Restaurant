using DevExpress.Utils.VisualEffects;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.UserControls
{
   public class ControlBadgButton:SimpleButton
    {
        private AdornerUIManager manager = new AdornerUIManager();
        private ContainerControl container;
        private Badge badgeButton = new Badge();
        private int count = 0;
        private Font badgeFont = new Font("Tahoma", 9, FontStyle.Bold);
        private Color badgeBackColor = Color.Red;
        private Color badgeForeColor = Color.White;
        private ContentAlignment alignment;

        public ControlBadgButton()
        {
            this.Click += ButtonClick;
            badgeButton.TargetElement = this;
            badgeButton.Properties.Location = alignment;
            manager.Elements.Add(badgeButton);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Count = 0;
        }

        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                if (value==0)
                {
                    badgeButton.Visible = false;
                }
                else
                {
                    badgeButton.Visible = true;
                    badgeButton.Properties.Text = count.ToString();
                }
            }
        }
        public ContainerControl ContainerControl
        {
            get { return container; }
            set
            {
                container = value;
                manager.Owner = value;

            }
        }
        public Font BadgeFont
        {
            get
            {
                return badgeFont;
            }
            set
            {
                badgeButton.Appearance.Font = value;
                badgeFont = value;
            }
        }
        public Color BadgeBackColor
        {
            get
            {
                return badgeBackColor;
            }
            set
            {
                badgeButton.Appearance.BackColor = value;
                badgeBackColor = value;
            }
        }
        public Color BadgeForeColor
        {
            get
            {
                return badgeForeColor;
            }
            set
            {
                badgeButton.Appearance.ForeColor = value;
                badgeForeColor = value;
            }
        }
        public ContentAlignment BadgeAligment
        {
            get { return alignment; }
            set
            {
                badgeButton.Properties.Location = value;
                alignment = value;
            }
        }
        
    }
}
