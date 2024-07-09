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
            this.txtInsertGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsertAddres = new System.Windows.Forms.TextBox();
            this.btnInsertAddress = new System.Windows.Forms.Button();
            this.dataGridViewSql = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSelect = new System.Windows.Forms.TextBox();
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
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnGroupStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnCurrentGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
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
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cmbGroupNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGroupNum.Name = "cmbGroupNum";
            this.cmbGroupNum.Size = new System.Drawing.Size(79, 32);
            this.cmbGroupNum.TabIndex = 4;
            // 
            // btnImportCorrectFile
            // 
            this.btnImportCorrectFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImportCorrectFile.Location = new System.Drawing.Point(196, 109);
            this.btnImportCorrectFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnExportJson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1323, 834);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Графік відключень";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtInsertGroup);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtInsertAddres);
            this.tabPage2.Controls.Add(this.btnInsertAddress);
            this.tabPage2.Controls.Add(this.dataGridViewSql);
            this.tabPage2.Controls.Add(this.btnSelect);
            this.tabPage2.Controls.Add(this.txtSelect);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1323, 834);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DB select";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtInsertGroup
            // 
            this.txtInsertGroup.Location = new System.Drawing.Point(920, 118);
            this.txtInsertGroup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInsertGroup.Name = "txtInsertGroup";
            this.txtInsertGroup.Size = new System.Drawing.Size(180, 29);
            this.txtInsertGroup.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(970, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Група";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Адреса";
            // 
            // txtInsertAddres
            // 
            this.txtInsertAddres.Location = new System.Drawing.Point(295, 120);
            this.txtInsertAddres.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInsertAddres.Name = "txtInsertAddres";
            this.txtInsertAddres.Size = new System.Drawing.Size(576, 29);
            this.txtInsertAddres.TabIndex = 4;
            // 
            // btnInsertAddress
            // 
            this.btnInsertAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsertAddress.Location = new System.Drawing.Point(77, 105);
            this.btnInsertAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.dataGridViewSql.Location = new System.Drawing.Point(295, 238);
            this.dataGridViewSql.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewSql.Name = "dataGridViewSql";
            this.dataGridViewSql.RowHeadersVisible = false;
            this.dataGridViewSql.RowHeadersWidth = 72;
            this.dataGridViewSql.Size = new System.Drawing.Size(777, 436);
            this.dataGridViewSql.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelect.Location = new System.Drawing.Point(77, 41);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.txtSelect.Location = new System.Drawing.Point(295, 41);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(774, 29);
            this.txtSelect.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 871);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtInsertGroup;
        private System.Windows.Forms.Label label2;
    }
}

