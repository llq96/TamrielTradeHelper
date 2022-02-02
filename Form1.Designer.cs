
namespace TamrielTradeApp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabelBtn_UnHideAll = new System.Windows.Forms.LinkLabel();
            this.linkLabelButton_copyURL = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnUpdateItemsList = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_loadingNowInfo = new System.Windows.Forms.Label();
            this.checkBox_IsHideUserHided = new System.Windows.Forms.CheckBox();
            this.checkBox_IsHideOld = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Время = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonHide = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel2MinSize = 20;
            this.splitContainer1.Size = new System.Drawing.Size(701, 861);
            this.splitContainer1.SplitterDistance = 643;
            this.splitContainer1.SplitterIncrement = 10;
            this.splitContainer1.SplitterWidth = 12;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 861);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.linkLabelBtn_UnHideAll);
            this.groupBox1.Controls.Add(this.linkLabelButton_copyURL);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label_loadingNowInfo);
            this.groupBox1.Controls.Add(this.checkBox_IsHideUserHided);
            this.groupBox1.Controls.Add(this.checkBox_IsHideOld);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 134);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // linkLabelBtn_UnHideAll
            // 
            this.linkLabelBtn_UnHideAll.AutoSize = true;
            this.linkLabelBtn_UnHideAll.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabelBtn_UnHideAll.Location = new System.Drawing.Point(125, 23);
            this.linkLabelBtn_UnHideAll.Name = "linkLabelBtn_UnHideAll";
            this.linkLabelBtn_UnHideAll.Size = new System.Drawing.Size(168, 15);
            this.linkLabelBtn_UnHideAll.TabIndex = 4;
            this.linkLabelBtn_UnHideAll.TabStop = true;
            this.linkLabelBtn_UnHideAll.Text = "очистить список скрытого(0)";
            this.linkLabelBtn_UnHideAll.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabelBtn_UnHideAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelBtn_UnHideAll_LinkClicked);
            // 
            // linkLabelButton_copyURL
            // 
            this.linkLabelButton_copyURL.AutoSize = true;
            this.linkLabelButton_copyURL.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabelButton_copyURL.Location = new System.Drawing.Point(342, 23);
            this.linkLabelButton_copyURL.Name = "linkLabelButton_copyURL";
            this.linkLabelButton_copyURL.Size = new System.Drawing.Size(120, 15);
            this.linkLabelButton_copyURL.TabIndex = 8;
            this.linkLabelButton_copyURL.TabStop = true;
            this.linkLabelButton_copyURL.Text = "скопировать ссылку";
            this.linkLabelButton_copyURL.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabelButton_copyURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelButton_copyURL_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnUpdateItemsList);
            this.panel1.Controls.Add(this.text1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(484, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 44);
            this.panel1.TabIndex = 7;
            // 
            // BtnUpdateItemsList
            // 
            this.BtnUpdateItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateItemsList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdateItemsList.BackgroundImage")));
            this.BtnUpdateItemsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpdateItemsList.Location = new System.Drawing.Point(114, 7);
            this.BtnUpdateItemsList.Name = "BtnUpdateItemsList";
            this.BtnUpdateItemsList.Size = new System.Drawing.Size(32, 32);
            this.BtnUpdateItemsList.TabIndex = 6;
            this.BtnUpdateItemsList.UseVisualStyleBackColor = true;
            this.BtnUpdateItemsList.Click += new System.EventHandler(this.BtnUpdateItemsList_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Location = new System.Drawing.Point(5, 4);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 15);
            this.text1.TabIndex = 5;
            this.text1.Text = "Автообновление";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Location = new System.Drawing.Point(5, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(5, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_loadingNowInfo
            // 
            this.label_loadingNowInfo.AutoEllipsis = true;
            this.label_loadingNowInfo.Location = new System.Drawing.Point(300, 24);
            this.label_loadingNowInfo.Name = "label_loadingNowInfo";
            this.label_loadingNowInfo.Size = new System.Drawing.Size(245, 105);
            this.label_loadingNowInfo.TabIndex = 0;
            this.label_loadingNowInfo.Text = "Поиск :\r\nСТРОКА_СТРОКА\r\nСТРОКА_СТРОКА\r\nСТРОКА_СТРОКА\r\nСТРОКА_СТРОКА\r\nСТРОКА_СТРОК" +
    "А";
            // 
            // checkBox_IsHideUserHided
            // 
            this.checkBox_IsHideUserHided.AutoSize = true;
            this.checkBox_IsHideUserHided.Checked = true;
            this.checkBox_IsHideUserHided.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IsHideUserHided.Location = new System.Drawing.Point(3, 23);
            this.checkBox_IsHideUserHided.Name = "checkBox_IsHideUserHided";
            this.checkBox_IsHideUserHided.Size = new System.Drawing.Size(128, 19);
            this.checkBox_IsHideUserHided.TabIndex = 1;
            this.checkBox_IsHideUserHided.Text = "Скрывать скрытое";
            this.checkBox_IsHideUserHided.UseVisualStyleBackColor = true;
            // 
            // checkBox_IsHideOld
            // 
            this.checkBox_IsHideOld.AutoSize = true;
            this.checkBox_IsHideOld.Location = new System.Drawing.Point(3, 48);
            this.checkBox_IsHideOld.Name = "checkBox_IsHideOld";
            this.checkBox_IsHideOld.Size = new System.Drawing.Size(121, 19);
            this.checkBox_IsHideOld.TabIndex = 3;
            this.checkBox_IsHideOld.Text = "Скрывать старые";
            this.checkBox_IsHideOld.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 24;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.ItemName,
            this.Place,
            this.Price,
            this.Count,
            this.PriceFull,
            this.Время,
            this.ButtonHide,
            this.GUID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(637, 694);
            this.dataGridView1.TabIndex = 0;
            // 
            // Image
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Image.DefaultCellStyle = dataGridViewCellStyle2;
            this.Image.FillWeight = 34F;
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Название";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Place
            // 
            this.Place.HeaderText = "Место";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 50F;
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.FillWeight = 25F;
            this.Count.HeaderText = "шт.";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // PriceFull
            // 
            this.PriceFull.FillWeight = 60F;
            this.PriceFull.HeaderText = "Итого";
            this.PriceFull.Name = "PriceFull";
            this.PriceFull.ReadOnly = true;
            // 
            // Время
            // 
            this.Время.FillWeight = 50F;
            this.Время.HeaderText = "Время";
            this.Время.Name = "Время";
            this.Время.ReadOnly = true;
            // 
            // ButtonHide
            // 
            this.ButtonHide.FillWeight = 50F;
            this.ButtonHide.HeaderText = "Скрыть";
            this.ButtonHide.Name = "ButtonHide";
            this.ButtonHide.ReadOnly = true;
            this.ButtonHide.Text = "Скрыть";
            // 
            // GUID
            // 
            this.GUID.HeaderText = "guid";
            this.GUID.Name = "GUID";
            this.GUID.ReadOnly = true;
            this.GUID.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки(Скрыть)";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 861);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tamriel Trade Helper";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonHide;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_loadingNowInfo;
        public System.Windows.Forms.CheckBox checkBox_IsHideUserHided;
        public System.Windows.Forms.CheckBox checkBox_IsHideOld;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.LinkLabel linkLabelBtn_UnHideAll;
        private System.Windows.Forms.LinkLabel linkLabelButton_copyURL;
        private System.Windows.Forms.Button BtnUpdateItemsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
    }
}

