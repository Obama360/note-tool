using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq; //for XML stuff
using System.Xml.XPath; //for XML stuff
using System.Runtime.InteropServices; //for titlebar
using Pendenzen;

namespace NoteTool
{
    public partial class FormMain : Form
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

        public FormMain()
        {
            InitializeComponent();

            //resizeable stuff
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

                bool editing { get; set; }

        private void buttonNewEntry_Click(object sender, EventArgs e)
        {
            addEntry();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Pendenzen.Properties.Settings.Default.Location;
            this.Size = Pendenzen.Properties.Settings.Default.Size;

            editing = false;

            buttonEdit.Enabled = false;
            buttonSaveEdits.Visible = false;
            buttonSaveEdits.Enabled = false;
            buttonCancelEdits.Visible = false;
            buttonCancelEdits.Enabled = false;
            buttonRenameEntry.Enabled = false;
            buttonRenameEntry.Visible = false;

            if (!File.Exists(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"))){
                Directory.CreateDirectory(Path.GetDirectoryName(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml")));
                string[] lines ={"<?xml version=\"1.0\" encoding=\"utf-8\"?>", "<entrys>", "</entrys>" };
                System.IO.File.WriteAllLines(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"), lines);
            }

            loadEntrys();
        }

        private void loadEntrys()
        {

            listBoxEntrys.Items.Clear();
            try
            {
                XDocument entrys = XDocument.Load(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));
                
                foreach (var entry in entrys.Descendants("entry"))
                {
                    listBoxEntrys.Items.Add(entry.Element("name").Value);
                }
            } catch
            {

            }
        }

        private void deleteEntry()
        {
            if (Convert.ToString(listBoxEntrys.SelectedItem) != "")
            {
                DialogResult dialogResult = MessageBox.Show("Diesen Eintrag löschen:\n" + Convert.ToString(listBoxEntrys.SelectedItem) + "?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    XDocument entrys = XDocument.Load(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));
                    entrys.Descendants("entry")
                              .Where(x => (string)x.Element("name") == Convert.ToString(listBoxEntrys.SelectedItem)).Remove();

                    entrys.Save(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));

                    loadEntrys();
                    richTextBoxInfo.Text = "";
                }
            }
        }

        private void addEntry()
        {
            Pendenzen.Properties.Settings.Default.Location = this.Location;
            Pendenzen.Properties.Settings.Default.Size = this.Size;
            Pendenzen.Properties.Settings.Default.Save();

            FormNewEntry formNewEntry = new FormNewEntry();
            formNewEntry.ShowDialog();
            loadEntrys();
        }

        private void cancelEdits()
        {
            tableLayoutPanel3.Enabled = true;
            editing = false;

            listBoxEntrys.Enabled = true;

            tableLayoutPanel1.Size = new Size(tableLayoutPanel1.Size.Width, tableLayoutPanel1.Size.Height + 30);
            richTextBoxInfo.ReadOnly = true;
            richTextBoxInfo.BackColor = Color.FromArgb(227, 247, 255);

            buttonSaveEdits.Visible = false;
            buttonSaveEdits.Enabled = false;
            buttonCancelEdits.Visible = false;
            buttonCancelEdits.Enabled = false;
            buttonRenameEntry.Enabled = false;
            buttonRenameEntry.Visible = false;

            //reload old entry text
            XDocument entrys = XDocument.Load(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));

            foreach (var entry in entrys.Descendants("entry"))
            {
                if (Convert.ToString(listBoxEntrys.SelectedItem) == entry.Element("name").Value)
                {
                    richTextBoxInfo.Text = entry.Element("info").Value;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(listBoxEntrys.SelectedItem) != "")
            {
                buttonEdit.Enabled = true;
            }

            XDocument entrys = XDocument.Load(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));

            foreach (var entry in entrys.Descendants("entry"))
            {
                if (Convert.ToString(listBoxEntrys.SelectedItem) == entry.Element("name").Value)
                {
                    richTextBoxInfo.Text = entry.Element("info").Value;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteEntry();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!editing && Convert.ToString(listBoxEntrys.SelectedItem) != "")
            {
                tableLayoutPanel3.Enabled = false; //panel with buttons
                editing = true;

                listBoxEntrys.Enabled = false;

                tableLayoutPanel1.Size = new Size(tableLayoutPanel1.Size.Width, tableLayoutPanel1.Size.Height - 30);
                richTextBoxInfo.ReadOnly = false;
                richTextBoxInfo.BackColor = Color.White;

                buttonSaveEdits.Visible = true;
                buttonSaveEdits.Enabled = true;
                buttonCancelEdits.Visible = true;
                buttonCancelEdits.Enabled = true;
                buttonRenameEntry.Enabled = true;
                buttonRenameEntry.Visible = true;
            }
        }

        private void buttonCancelEdits_Click(object sender, EventArgs e)
        {
            cancelEdits();
        }

        private void buttonSaveEdits_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Enabled = true;
            editing = false;

            listBoxEntrys.Enabled = true;

            tableLayoutPanel1.Size = new Size(tableLayoutPanel1.Size.Width, tableLayoutPanel1.Size.Height + 30);
            richTextBoxInfo.ReadOnly = true;
            richTextBoxInfo.BackColor = Color.FromArgb(227, 247, 255);

            buttonSaveEdits.Visible = false;
            buttonSaveEdits.Enabled = false;
            buttonCancelEdits.Visible = false;
            buttonCancelEdits.Enabled = false;
            buttonRenameEntry.Enabled = false;
            buttonRenameEntry.Visible = false;

            var entrys = XDocument.Load(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));
            
            entrys.XPathSelectElement("//entry/name[text()='"+listBoxEntrys.SelectedItem+"']/../info").Value = richTextBoxInfo.Text;
            
            entrys.Save(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.Text = "";
            loadEntrys();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Pendenzen.Properties.Settings.Default.Location = this.Location;
            Pendenzen.Properties.Settings.Default.Size = this.Size;
            Pendenzen.Properties.Settings.Default.Save();

            FormInfo formInfo = new FormInfo();
            formInfo.Show();
        }

        private void listBoxEntrys_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && buttonDelete.Enabled == true)
            {
                deleteEntry();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control && buttonNewEntry.Enabled == true)
            {
                addEntry();
            }

            if (e.KeyCode == Keys.R && e.Modifiers == Keys.Control && buttonRefresh.Enabled == true)
            {
                richTextBoxInfo.Text = "";
                loadEntrys();
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (buttonCancelEdits.Enabled)
                {
                    cancelEdits();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pendenzen.Properties.Settings.Default.Location = this.Location;
            Pendenzen.Properties.Settings.Default.Size = this.Size;
            Pendenzen.Properties.Settings.Default.Save();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonRenameEntry_Click(object sender, EventArgs e)
        {
            Pendenzen.Properties.Settings.Default.Location = this.Location;
            Pendenzen.Properties.Settings.Default.Size = this.Size;
            Pendenzen.Properties.Settings.Default.Save();

            FormRenameEntry formRenameEntry = new FormRenameEntry(Convert.ToString(listBoxEntrys.SelectedItem));
            formRenameEntry.ShowDialog();

            cancelEdits();
            loadEntrys();
        }

        private void richTextBoxInfo_TextChanged(object sender, EventArgs e)
        {
            if (buttonRenameEntry.Visible)
                buttonRenameEntry.Visible = false;
        }
    }
}
