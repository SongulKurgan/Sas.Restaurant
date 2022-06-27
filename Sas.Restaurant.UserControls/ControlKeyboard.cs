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
    public partial class ControlKeyboard : DevExpress.XtraEditors.XtraUserControl
    {
        private bool capsLock = true;
        private KeyBoardButtonType buttonType = KeyBoardButtonType.Standart;
        private BaseEdit focusTextEdit=null;
        public ControlKeyboard()
        {
            InitializeComponent();
        }
        public BaseEdit FocusTextBox
        {
            get { return focusTextEdit; }
            set
            {
                focusTextEdit = value;
            }
        }
        public KeyBoardButtonType KeyBoardButtonType
        {
            get
            {
                return buttonType;
            }
            set
            {
                buttonType = value;
                foreach (KeyboardButton button in layoutControl1.Controls.OfType<KeyboardButton>().ToList())
                {
                    switch (value)
                    {
                        case KeyBoardButtonType.Standart:
                            button.Text = button.First.ToString();
                            break;
                        case KeyBoardButtonType.Shift:
                            button.Text = button.Second.ToString();
                            if (button.Text == "&")
                            {
                                button.Text = "&&";
                            }
                            break;
                        case KeyBoardButtonType.Alt:
                            button.Text = button.Third.ToString();
                            break;
                    }
                }
            }
        }

    public bool CapsLock
        {
            get
            {
                return capsLock;
            }
            set
            {
                capsLock = value;
                foreach (KeyboardButton button in layoutControl1.Controls.OfType<KeyboardButton>().ToList())
                {
                    if (value)
                    {
                        button.Text = button.Text.ToUpper();
                    }
                    else
                    {
                        button.Text = button.Text.ToLower();
                    }
                }
            }
        }

        private void KeyBoardButtonClick(object sender, EventArgs e)
        {
            KeyboardButton button = (KeyboardButton)sender;
            if (focusTextEdit!=null)
            {
                focusTextEdit.Focus();
            }
            if (!String.IsNullOrEmpty(button.Text))
            {
                if (button.Text=="&&")
                {
                    SendKeys.Send("{&}");
                }
                else
                {
                    SendKeys.Send("{" + button.Text + "}");
                }
                
            }

        }

        private void KeyEsc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void keyTab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void keyCapsLock_CheckedChanged(object sender, EventArgs e)
        {
            CapsLock = keyCapsLock.Checked;
        }

        private void keyBackSpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void keyDelete_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DEL}");
        }

        private void keyYukariOk_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void keySolOk_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void keyAsagiOk_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void keySagOk_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void keyEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void keySpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{SPACE}");
        }

        private void keySolShift_CheckedChanged(object sender, EventArgs e)
        {
            if (keySolShift.Checked)
            {
                KeyBoardButtonType = KeyBoardButtonType.Shift;
            }
            else
            {
                KeyBoardButtonType = KeyBoardButtonType.Standart;
            }

        }

        private void keySagShift_CheckedChanged(object sender, EventArgs e)
        {
            if (keySagShift.Checked)
            {
                KeyBoardButtonType = KeyBoardButtonType.Shift;
            }
            else
            {
                KeyBoardButtonType = KeyBoardButtonType.Standart;
            }
        }

        private void keyAlt_CheckedChanged(object sender, EventArgs e)
        {
            if (keyAlt.Checked)
            {
                KeyBoardButtonType = KeyBoardButtonType.Alt;
            }
            else
            {
                KeyBoardButtonType = KeyBoardButtonType.Standart;
            }
        }
    }
}
