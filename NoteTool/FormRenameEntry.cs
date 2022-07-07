using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //for titlebar
using System.Xml.Linq;
using System.Xml.XPath;

namespace Pendenzen
{
    public partial class FormRenameEntry : Form
    {
        //start of shadow stuff
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        //end of shadow stuff

        //titlebar stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //titlebar stuff

        public FormRenameEntry(string ItemName)
        {
            InitializeComponent();
            labelEntry.Text = ItemName;
        }

        private void FormRenameEntry_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Pendenzen.Properties.Settings.Default.Location.X + 20, Pendenzen.Properties.Settings.Default.Location.Y + 20);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            RenameEntry();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRenameEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            else if ((e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control))
            {
                RenameEntry();
            }

        }

        private void RenameEntry()
        {
            if (textBoxNewEntryName.Text != "")
            {
                try
                {
                    var entrys = XDocument.Load(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));
                    entrys.XPathSelectElement("//entry/name[text()='" + labelEntry.Text + "']/../name").Value = textBoxNewEntryName.Text;
                    entrys.Save(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Eintrag konnte nicht umbenannt werden!", "Nix gut!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Bitte das Feld nicht leer lassen!", "Wie willst du es finden ohne Namen?", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
