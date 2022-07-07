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

namespace NoteTool
{
    public partial class FormInfo : Form
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

        public FormInfo()
        {
            InitializeComponent();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo, ich bin ein Knopf!", "Hello how are you", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Pendenzen.Properties.Settings.Default.Location.X + 20, Pendenzen.Properties.Settings.Default.Location.Y + 20);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
