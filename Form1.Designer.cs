namespace Cashalot_Dev
{
    partial class Form1
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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnGroupStatus = new System.Windows.Forms.Button();
            this.btnCurrentGroups = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cmbGroupNum = new System.Windows.Forms.ComboBox();
            this.btnImportCorrectFile = new System.Windows.Forms.Button();
            this.btnExportJson = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.btnUpdateAddress = new System.Windows.Forms.Button();
            this.txtUpdateAddressGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateAddres = new System.Windows.Forms.TextBox();
            this.txtInsertAddrssGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsertAddres = new System.Windows.Forms.TextBox();
            this.btnInsertAddress = new System.Windows.Forms.Button();
            this.dataGridViewSql = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.btnInsertSchedule = new System.Windows.Forms.Button();
            this.txtInsertDay = new System.Windows.Forms.TextBox();
            this.txtInsertTimeFor = new System.Windows.Forms.TextBox();
            this.txtInsertTimeTo = new System.Windows.Forms.TextBox();
            this.txtInsertScheduleGroup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSql)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImport.Location = new System.Drawing.Point(196, 28);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(238, 76);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Імпорт";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnGroupStatus
            // 
            this.btnGroupStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGroupStatus.Location = new System.Drawing.Point(497, 28);
            this.btnGroupStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupStatus.Name = "btnGroupStatus";
            this.btnGroupStatus.Size = new System.Drawing.Size(238, 76);
            this.btnGroupStatus.TabIndex = 0;
            this.btnGroupStatus.Text = "Стан по групах";
            this.btnGroupStatus.UseVisualStyleBackColor = true;
            this.btnGroupStatus.Click += new System.EventHandler(this.btnGroupStatus_Click);
            // 
            // btnCurrentGroups
            // 
            this.btnCurrentGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCurrentGroups.Location = new System.Drawing.Point(790, 28);
            this.btnCurrentGroups.Margin = new System.Windows.Forms.Padding(4);
            this.btnCurrentGroups.Name = "btnCurrentGroups";
            this.btnCurrentGroups.Size = new System.Drawing.Size(238, 76);
            this.btnCurrentGroups.TabIndex = 0;
            this.btnCurrentGroups.Text = "Стан по обраній групі";
            this.btnCurrentGroups.UseVisualStyleBackColor = true;
            this.btnCurrentGroups.Click += new System.EventHandler(this.btnCurrentGroups_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(196, 218);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(975, 432);
            this.dataGridView.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStatus.Location = new System.Drawing.Point(196, 685);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(970, 29);
            this.txtStatus.TabIndex = 2;
            // 
            // cmbGroupNum
            // 
            this.cmbGroupNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbGroupNum.FormattingEnabled = true;
            this.cmbGroupNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbGroupNum.Location = new System.Drawing.Point(1034, 50);
            this.cmbGroupNum.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGroupNum.Name = "cmbGroupNum";
            this.cmbGroupNum.Size = new System.Drawing.Size(79, 32);
            this.cmbGroupNum.TabIndex = 4;
            // 
            // btnImportCorrectFile
            // 
            this.btnImportCorrectFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImportCorrectFile.Location = new System.Drawing.Point(196, 109);
            this.btnImportCorrectFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportCorrectFile.Name = "btnImportCorrectFile";
            this.btnImportCorrectFile.Size = new System.Drawing.Size(238, 81);
            this.btnImportCorrectFile.TabIndex = 5;
            this.btnImportCorrectFile.Text = "Імпорт корегуючого файлу";
            this.btnImportCorrectFile.UseVisualStyleBackColor = true;
            this.btnImportCorrectFile.Click += new System.EventHandler(this.btnImportCorrectFile_Click);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportJson.Location = new System.Drawing.Point(497, 122);
            this.btnExportJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(238, 68);
            this.btnExportJson.TabIndex = 6;
            this.btnExportJson.Text = "Експорт у JSON";
            this.btnExportJson.UseVisualStyleBackColor = true;
            this.btnExportJson.Click += new System.EventHandler(this.btnExportJson_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1331, 871);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGroupStatus);
            this.tabPage1.Controls.Add(this.btnExportJson);
            this.tabPage1.Controls.Add(this.btnImport);
            this.tabPage1.Controls.Add(this.btnImportCorrectFile);
            this.tabPage1.Controls.Add(this.btnCurrentGroups);
            this.tabPage1.Controls.Add(this.cmbGroupNum);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.txtStatus);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1323, 834);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Графік відключень";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtInsertScheduleGroup);
            this.tabPage2.Controls.Add(this.txtInsertTimeTo);
            this.tabPage2.Controls.Add(this.txtInsertTimeFor);
            this.tabPage2.Controls.Add(this.txtInsertDay);
            this.tabPage2.Controls.Add(this.btnInsertSchedule);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtUpdateId);
            this.tabPage2.Controls.Add(this.btnUpdateAddress);
            this.tabPage2.Controls.Add(this.txtUpdateAddressGroup);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtUpdateAddres);
            this.tabPage2.Controls.Add(this.txtInsertAddrssGroup);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtInsertAddres);
            this.tabPage2.Controls.Add(this.btnInsertAddress);
            this.tabPage2.Controls.Add(this.dataGridViewSql);
            this.tabPage2.Controls.Add(this.btnSelect);
            this.tabPage2.Controls.Add(this.txtSelect);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1323, 834);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DB select";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID";
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUpdateId.Location = new System.Drawing.Point(399, 192);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.ReadOnly = true;
            this.txtUpdateId.Size = new System.Drawing.Size(52, 29);
            this.txtUpdateId.TabIndex = 14;
            this.txtUpdateId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdateAddress
            // 
            this.btnUpdateAddress.Location = new System.Drawing.Point(181, 177);
            this.btnUpdateAddress.Name = "btnUpdateAddress";
            this.btnUpdateAddress.Size = new System.Drawing.Size(182, 49);
            this.btnUpdateAddress.TabIndex = 13;
            this.btnUpdateAddress.Text = "Оновити адресу";
            this.btnUpdateAddress.UseVisualStyleBackColor = true;
            this.btnUpdateAddress.Click += new System.EventHandler(this.btnUpdateAddress_Click);
            // 
            // txtUpdateAddressGroup
            // 
            this.txtUpdateAddressGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUpdateAddressGroup.Location = new System.Drawing.Point(1025, 193);
            this.txtUpdateAddressGroup.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateAddressGroup.Name = "txtUpdateAddressGroup";
            this.txtUpdateAddressGroup.Size = new System.Drawing.Size(152, 29);
            this.txtUpdateAddressGroup.TabIndex = 12;
            this.txtUpdateAddressGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1074, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Група";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Адреса";
            // 
            // txtUpdateAddres
            // 
            this.txtUpdateAddres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUpdateAddres.Location = new System.Drawing.Point(472, 194);
            this.txtUpdateAddres.Margin = new System.Windows.Forms.Padding(6);
            this.txtUpdateAddres.Name = "txtUpdateAddres";
            this.txtUpdateAddres.Size = new System.Drawing.Size(503, 29);
            this.txtUpdateAddres.TabIndex = 9;
            // 
            // txtInsertAddrssGroup
            // 
            this.txtInsertAddrssGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInsertAddrssGroup.Location = new System.Drawing.Point(1024, 118);
            this.txtInsertAddrssGroup.Margin = new System.Windows.Forms.Padding(6);
            this.txtInsertAddrssGroup.Name = "txtInsertAddrssGroup";
            this.txtInsertAddrssGroup.Size = new System.Drawing.Size(152, 29);
            this.txtInsertAddrssGroup.TabIndex = 7;
            this.txtInsertAddrssGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1074, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Група";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Адреса";
            // 
            // txtInsertAddres
            // 
            this.txtInsertAddres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInsertAddres.Location = new System.Drawing.Point(399, 120);
            this.txtInsertAddres.Margin = new System.Windows.Forms.Padding(6);
            this.txtInsertAddres.Name = "txtInsertAddres";
            this.txtInsertAddres.Size = new System.Drawing.Size(576, 29);
            this.txtInsertAddres.TabIndex = 4;
            // 
            // btnInsertAddress
            // 
            this.btnInsertAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsertAddress.Location = new System.Drawing.Point(181, 105);
            this.btnInsertAddress.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsertAddress.Name = "btnInsertAddress";
            this.btnInsertAddress.Size = new System.Drawing.Size(182, 52);
            this.btnInsertAddress.TabIndex = 3;
            this.btnInsertAddress.Text = "Додати адресу";
            this.btnInsertAddress.UseVisualStyleBackColor = true;
            this.btnInsertAddress.Click += new System.EventHandler(this.btnInsertAddress_Click);
            // 
            // dataGridViewSql
            // 
            this.dataGridViewSql.AllowUserToAddRows = false;
            this.dataGridViewSql.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSql.Location = new System.Drawing.Point(284, 321);
            this.dataGridViewSql.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewSql.Name = "dataGridViewSql";
            this.dataGridViewSql.ReadOnly = true;
            this.dataGridViewSql.RowHeadersVisible = false;
            this.dataGridViewSql.RowHeadersWidth = 72;
            this.dataGridViewSql.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSql.Size = new System.Drawing.Size(777, 436);
            this.dataGridViewSql.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelect.Location = new System.Drawing.Point(181, 41);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(182, 42);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSelect
            // 
            this.txtSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSelect.Location = new System.Drawing.Point(399, 41);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(6);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(774, 29);
            this.txtSelect.TabIndex = 0;
            // 
            // btnInsertSchedule
            // 
            this.btnInsertSchedule.Location = new System.Drawing.Point(181, 263);
            this.btnInsertSchedule.Name = "btnInsertSchedule";
            this.btnInsertSchedule.Size = new System.Drawing.Size(182, 49);
            this.btnInsertSchedule.TabIndex = 16;
            this.btnInsertSchedule.Text = "Додати графік";
            this.btnInsertSchedule.UseVisualStyleBackColor = true;
            this.btnInsertSchedule.Click += new System.EventHandler(this.btnInsertSchedule_Click);
            // 
            // txtInsertDay
            // 
            this.txtInsertDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInsertDay.Location = new System.Drawing.Point(382, 272);
            this.txtInsertDay.Margin = new System.Windows.Forms.Padding(6);
            this.txtInsertDay.Name = "txtInsertDay";
            this.txtInsertDay.Size = new System.Drawing.Size(175, 29);
            this.txtInsertDay.TabIndex = 17;
            this.txtInsertDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInsertTimeFor
            // 
            this.txtInsertTimeFor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInsertTimeFor.Location = new System.Drawing.Point(569, 272);
            this.txtInsertTimeFor.Margin = new System.Windows.Forms.Padding(6);
            this.txtInsertTimeFor.Name = "txtInsertTimeFor";
            this.txtInsertTimeFor.Size = new System.Drawing.Size(81, 29);
            this.txtInsertTimeFor.TabIndex = 18;
            this.txtInsertTimeFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInsertTimeTo
            // 
            this.txtInsertTimeTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInsertTimeTo.Location = new System.Drawing.Point(662, 272);
            this.txtInsertTimeTo.Margin = new System.Windows.Forms.Padding(6);
            this.txtInsertTimeTo.Name = "txtInsertTimeTo";
            this.txtInsertTimeTo.Size = new System.Drawing.Size(81, 29);
            this.txtInsertTimeTo.TabIndex = 19;
            this.txtInsertTimeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInsertScheduleGroup
            // 
            this.txtInsertScheduleGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInsertScheduleGroup.Location = new System.Drawing.Point(755, 272);
            this.txtInsertScheduleGroup.Margin = new System.Windows.Forms.Padding(6);
            this.txtInsertScheduleGroup.Name = "txtInsertScheduleGroup";
            this.txtInsertScheduleGroup.Size = new System.Drawing.Size(81, 29);
            this.txtInsertScheduleGroup.TabIndex = 20;
            this.txtInsertScheduleGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "День";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(670, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Час до";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(578, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Час з";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(761, 241);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Група";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 871);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1122, 889);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashalot-Dev";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSql)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnGroupStatus;
        private System.Windows.Forms.Button btnCurrentGroups;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ComboBox cmbGroupNum;
        private System.Windows.Forms.Button btnImportCorrectFile;
        private System.Windows.Forms.Button btnExportJson;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.DataGridView dataGridViewSql;
        private System.Windows.Forms.TextBox txtInsertAddres;
        private System.Windows.Forms.Button btnInsertAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsertAddrssGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdateAddressGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateAddres;
        private System.Windows.Forms.Button btnUpdateAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateId;
        private System.Windows.Forms.TextBox txtInsertScheduleGroup;
        private System.Windows.Forms.TextBox txtInsertTimeTo;
        private System.Windows.Forms.TextBox txtInsertTimeFor;
        private System.Windows.Forms.TextBox txtInsertDay;
        private System.Windows.Forms.Button btnInsertSchedule;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

