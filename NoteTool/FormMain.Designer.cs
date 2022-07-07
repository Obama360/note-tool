namespace NoteTool
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listBoxEntrys = new System.Windows.Forms.ListBox();
            this.buttonNewEntry = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSaveEdits = new System.Windows.Forms.Button();
            this.buttonCancelEdits = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.SplitContainer();
            this.buttonRenameEntry = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLayoutPanel1)).BeginInit();
            this.tableLayoutPanel1.Panel1.SuspendLayout();
            this.tableLayoutPanel1.Panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEntrys
            // 
            this.listBoxEntrys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEntrys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.listBoxEntrys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxEntrys.FormattingEnabled = true;
            this.listBoxEntrys.Location = new System.Drawing.Point(3, 3);
            this.listBoxEntrys.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.listBoxEntrys.Name = "listBoxEntrys";
            this.listBoxEntrys.Size = new System.Drawing.Size(241, 416);
            this.listBoxEntrys.TabIndex = 0;
            this.listBoxEntrys.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBoxEntrys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxEntrys_KeyDown);
            // 
            // buttonNewEntry
            // 
            this.buttonNewEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNewEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonNewEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNewEntry.BackgroundImage")));
            this.buttonNewEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNewEntry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonNewEntry.FlatAppearance.BorderSize = 2;
            this.buttonNewEntry.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonNewEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonNewEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.buttonNewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewEntry.Location = new System.Drawing.Point(3, 3);
            this.buttonNewEntry.Name = "buttonNewEntry";
            this.buttonNewEntry.Size = new System.Drawing.Size(34, 33);
            this.buttonNewEntry.TabIndex = 2;
            this.buttonNewEntry.TabStop = false;
            this.buttonNewEntry.UseVisualStyleBackColor = false;
            this.buttonNewEntry.Click += new System.EventHandler(this.buttonNewEntry_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.richTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(3, 6);
            this.richTextBoxInfo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxInfo.Size = new System.Drawing.Size(565, 463);
            this.richTextBoxInfo.TabIndex = 4;
            this.richTextBoxInfo.TabStop = false;
            this.richTextBoxInfo.Text = "";
            this.richTextBoxInfo.WordWrap = false;
            this.richTextBoxInfo.TextChanged += new System.EventHandler(this.richTextBoxInfo_TextChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(43, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(34, 33);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEdit.BackgroundImage")));
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonEdit.FlatAppearance.BorderSize = 2;
            this.buttonEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(83, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(34, 33);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.TabStop = false;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSaveEdits
            // 
            this.buttonSaveEdits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveEdits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonSaveEdits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonSaveEdits.FlatAppearance.BorderSize = 0;
            this.buttonSaveEdits.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonSaveEdits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonSaveEdits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.buttonSaveEdits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveEdits.Location = new System.Drawing.Point(736, 478);
            this.buttonSaveEdits.Name = "buttonSaveEdits";
            this.buttonSaveEdits.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveEdits.TabIndex = 7;
            this.buttonSaveEdits.Text = "Speichern";
            this.buttonSaveEdits.UseVisualStyleBackColor = false;
            this.buttonSaveEdits.Click += new System.EventHandler(this.buttonSaveEdits_Click);
            // 
            // buttonCancelEdits
            // 
            this.buttonCancelEdits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelEdits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonCancelEdits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonCancelEdits.FlatAppearance.BorderSize = 0;
            this.buttonCancelEdits.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonCancelEdits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonCancelEdits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.buttonCancelEdits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelEdits.Location = new System.Drawing.Point(655, 478);
            this.buttonCancelEdits.Name = "buttonCancelEdits";
            this.buttonCancelEdits.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelEdits.TabIndex = 8;
            this.buttonCancelEdits.Text = "Abbrechen";
            this.buttonCancelEdits.UseVisualStyleBackColor = false;
            this.buttonCancelEdits.Click += new System.EventHandler(this.buttonCancelEdits_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxEntrys, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 469);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Controls.Add(this.buttonNewEntry, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonDelete, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEdit, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonRefresh, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonInfo, 5, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 429);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(238, 37);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.BackgroundImage")));
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 2;
            this.buttonRefresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Location = new System.Drawing.Point(161, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(34, 33);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.TabStop = false;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.BackgroundImage")));
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonInfo.FlatAppearance.BorderSize = 2;
            this.buttonInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.buttonInfo.Location = new System.Drawing.Point(201, 3);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(34, 33);
            this.buttonInfo.TabIndex = 8;
            this.buttonInfo.TabStop = false;
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 29);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(217)))), ((int)(((byte)(233)))));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(725, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(46, 29);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pendenzen";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(217)))), ((int)(((byte)(233)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(119)))), ((int)(((byte)(113)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(771, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(46, 29);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(250, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel1.Panel1
            // 
            this.tableLayoutPanel1.Panel1.AutoScroll = true;
            this.tableLayoutPanel1.Panel1.AutoScrollMinSize = new System.Drawing.Size(240, 0);
            this.tableLayoutPanel1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.tableLayoutPanel1.Panel1MinSize = 250;
            // 
            // tableLayoutPanel1.Panel2
            // 
            this.tableLayoutPanel1.Panel2.Controls.Add(this.richTextBoxInfo);
            this.tableLayoutPanel1.Panel2MinSize = 200;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 475);
            this.tableLayoutPanel1.SplitterDistance = 250;
            this.tableLayoutPanel1.SplitterWidth = 3;
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = false;
            // 
            // buttonRenameEntry
            // 
            this.buttonRenameEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRenameEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonRenameEntry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonRenameEntry.FlatAppearance.BorderSize = 0;
            this.buttonRenameEntry.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonRenameEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonRenameEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.buttonRenameEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRenameEntry.Location = new System.Drawing.Point(517, 478);
            this.buttonRenameEntry.Name = "buttonRenameEntry";
            this.buttonRenameEntry.Size = new System.Drawing.Size(114, 23);
            this.buttonRenameEntry.TabIndex = 0;
            this.buttonRenameEntry.TabStop = false;
            this.buttonRenameEntry.Text = "Eintrag umbenennen";
            this.buttonRenameEntry.UseVisualStyleBackColor = false;
            this.buttonRenameEntry.Click += new System.EventHandler(this.buttonRenameEntry_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(817, 507);
            this.Controls.Add(this.buttonRenameEntry);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancelEdits);
            this.Controls.Add(this.buttonSaveEdits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(727, 364);
            this.Name = "FormMain";
            this.Text = "Pendenzen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.Panel1.ResumeLayout(false);
            this.tableLayoutPanel1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableLayoutPanel1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEntrys;
        private System.Windows.Forms.Button buttonNewEntry;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSaveEdits;
        private System.Windows.Forms.Button buttonCancelEdits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.SplitContainer tableLayoutPanel1;
        private System.Windows.Forms.Button buttonRenameEntry;
    }
}

