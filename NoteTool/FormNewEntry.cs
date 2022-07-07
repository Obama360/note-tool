using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Runtime.InteropServices; //for titlebar

namespace NoteTool
{
    public partial class FormNewEntry : Form
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

        public FormNewEntry()
        {
            InitializeComponent();
        }

        private void FormNewEntry_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Pendenzen.Properties.Settings.Default.Location.X + 20, Pendenzen.Properties.Settings.Default.Location.Y + 20);
        }

        private void buttonNewEntryCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNewEntryCreate_Click(object sender, EventArgs e)
        {
            createEntry();
        }

        private void FormNewEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control)
            {
                createEntry();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void createEntry()
        {
            if (textBoxNewEntryName.Text != "")
            {
                try
                {
                    XDocument doc = XDocument.Load(Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));

                    XElement entry = new XElement("entry");
                    entry.Add(new XElement("name", textBoxNewEntryName.Text));
                    entry.Add(new XElement("info", richTextBoxNewEntryInfo.Text));
                    doc.Element("entrys").Add(entry);
                    doc.Save(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));

                    this.Close();
                } catch
                {
                   DialogResult dialogResult = MessageBox.Show("Das XML ist fehlerhaft oder existiert nicht!\nMöchten sie ein neues XML generieren?\n!ACHTUNG! beim neu-generieren werden alle Einträge gelöscht!", "Eintrag konnte nicht erstellt werden!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            //create directory if needed
                            if (!Directory.Exists(Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote")))
                                Directory.CreateDirectory(Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote"));
                            

                            //delete old xml if exists
                            if (File.Exists(Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml")))
                                File.Delete(Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"));

                            //create xml
                            Directory.CreateDirectory(Path.GetDirectoryName(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml")));
                            string[] lines = { "<?xml version=\"1.0\" encoding=\"utf-8\"?>", "<entrys>", "</entrys>" };
                            System.IO.File.WriteAllLines(@Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SuperNote\\entrys.xml"), lines);
                        } catch
                        {
                            MessageBox.Show("XML konnte nicht erstellt werden!\nBitte manuell im Roaming Ordner die Struktur: SuperNote\\entrys.xml\nMit Inhalt: \n<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<entrys>\n</entrys>");
                        }

                    }
                }
            }

            else
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!", "Mission failed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
