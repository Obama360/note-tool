namespace NoteTool
{
    partial class FormNewEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewEntryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNewEntryCancel = new System.Windows.Forms.Button();
            this.buttonNewEntryCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxNewEntryInfo = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eintrag Name:";
            // 
            // textBoxNewEntryName
            // 
            this.textBoxNewEntryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.textBoxNewEntryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewEntryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewEntryName.Location = new System.Drawing.Point(15, 55);
            this.textBoxNewEntryName.Name = "textBoxNewEntryName";
            this.textBoxNewEntryName.Size = new System.Drawing.Size(410, 17);
            this.textBoxNewEntryName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eintrag Informationen:";
            // 
            // buttonNewEntryCancel
            // 
            this.buttonNewEntryCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonNewEntryCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonNewEntryCancel.FlatAppearance.BorderSize = 0;
            this.buttonNewEntryCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonNewEntryCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonNewEntryCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.buttonNewEntryCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewEntryCancel.Location = new System.Drawing.Point(15, 391);
            this.buttonNewEntryCancel.Name = "buttonNewEntryCancel";
            this.buttonNewEntryCancel.Size = new System.Drawing.Size(82, 33);
            this.buttonNewEntryCancel.TabIndex = 4;
            this.buttonNewEntryCancel.Text = "Abbrechen";
            this.buttonNewEntryCancel.UseVisualStyleBackColor = false;
            this.buttonNewEntryCancel.Click += new System.EventHandler(this.buttonNewEntryCancel_Click);
            // 
            // buttonNewEntryCreate
            // 
            this.buttonNewEntryCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonNewEntryCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.buttonNewEntryCreate.FlatAppearance.BorderSize = 0;
            this.buttonNewEntryCreate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonNewEntryCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.buttonNewEntryCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.buttonNewEntryCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewEntryCreate.ForeColor = System.Drawing.Color.Black;
            this.buttonNewEntryCreate.Location = new System.Drawing.Point(343, 391);
            this.buttonNewEntryCreate.Name = "buttonNewEntryCreate";
            this.buttonNewEntryCreate.Size = new System.Drawing.Size(82, 33);
            this.buttonNewEntryCreate.TabIndex = 3;
            this.buttonNewEntryCreate.Text = "Erstellen";
            this.buttonNewEntryCreate.UseVisualStyleBackColor = false;
            this.buttonNewEntryCreate.Click += new System.EventHandler(this.buttonNewEntryCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(100, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(ESC)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(262, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "(CTRL + Enter)";
            // 
            // richTextBoxNewEntryInfo
            // 
            this.richTextBoxNewEntryInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.richTextBoxNewEntryInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNewEntryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.richTextBoxNewEntryInfo.Location = new System.Drawing.Point(15, 105);
            this.richTextBoxNewEntryInfo.Name = "richTextBoxNewEntryInfo";
            this.richTextBoxNewEntryInfo.Size = new System.Drawing.Size(410, 280);
            this.richTextBoxNewEntryInfo.TabIndex = 2;
            this.richTextBoxNewEntryInfo.Text = "";
            this.richTextBoxNewEntryInfo.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 26);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(9, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Neuer Eintrag";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
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
            this.buttonExit.Location = new System.Drawing.Point(391, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(46, 26);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormNewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(437, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBoxNewEntryInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonNewEntryCreate);
            this.Controls.Add(this.buttonNewEntryCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewEntryName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Neuer Eintrag";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormNewEntry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormNewEntry_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewEntryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNewEntryCancel;
        private System.Windows.Forms.Button buttonNewEntryCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxNewEntryInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}