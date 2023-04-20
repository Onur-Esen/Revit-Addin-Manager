
namespace Revit_Addin_Manager
{
    partial class AddinManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddinManager));
            this.listViewValues = new System.Windows.Forms.ListView();
            this.columnHeaderFile = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFolder = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPath = new System.Windows.Forms.ColumnHeader();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonNone = new System.Windows.Forms.Button();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBoxInstall = new System.Windows.Forms.GroupBox();
            this.radioButtonCurrent = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.comboBoxVersion = new System.Windows.Forms.ComboBox();
            this.groupBoxLang = new System.Windows.Forms.GroupBox();
            this.radioButtonJP = new System.Windows.Forms.RadioButton();
            this.radioButtonEN = new System.Windows.Forms.RadioButton();
            this.labelVer = new System.Windows.Forms.Label();
            this.radioButtonTR = new System.Windows.Forms.RadioButton();
            this.groupBoxInstall.SuspendLayout();
            this.groupBoxLang.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewValues
            // 
            this.listViewValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFile,
            this.columnHeaderName,
            this.columnHeaderFolder,
            this.columnHeaderPath});
            this.listViewValues.FullRowSelect = true;
            this.listViewValues.GridLines = true;
            this.listViewValues.HideSelection = false;
            this.listViewValues.Location = new System.Drawing.Point(12, 67);
            this.listViewValues.Name = "listViewValues";
            this.listViewValues.Size = new System.Drawing.Size(960, 445);
            this.listViewValues.TabIndex = 0;
            this.listViewValues.UseCompatibleStateImageBehavior = false;
            this.listViewValues.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFile
            // 
            this.columnHeaderFile.Text = "File Name";
            this.columnHeaderFile.Width = 290;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 120;
            // 
            // columnHeaderFolder
            // 
            this.columnHeaderFolder.Text = "Folder";
            this.columnHeaderFolder.Width = 70;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "File Path";
            this.columnHeaderPath.Width = 450;
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(413, 38);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(75, 23);
            this.buttonAll.TabIndex = 1;
            this.buttonAll.Text = "Select All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonNone
            // 
            this.buttonNone.Location = new System.Drawing.Point(494, 38);
            this.buttonNone.Name = "buttonNone";
            this.buttonNone.Size = new System.Drawing.Size(75, 23);
            this.buttonNone.TabIndex = 1;
            this.buttonNone.Text = "Deselect All";
            this.buttonNone.UseVisualStyleBackColor = true;
            this.buttonNone.Click += new System.EventHandler(this.buttonNone_Click);
            // 
            // buttonEnable
            // 
            this.buttonEnable.Location = new System.Drawing.Point(12, 518);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(75, 23);
            this.buttonEnable.TabIndex = 1;
            this.buttonEnable.Text = "Enable";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // buttonDisable
            // 
            this.buttonDisable.Location = new System.Drawing.Point(105, 518);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(75, 23);
            this.buttonDisable.TabIndex = 1;
            this.buttonDisable.Text = "Disable";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // buttonInstall
            // 
            this.buttonInstall.Location = new System.Drawing.Point(6, 57);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(75, 23);
            this.buttonInstall.TabIndex = 1;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(898, 622);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(898, 518);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // groupBoxInstall
            // 
            this.groupBoxInstall.Controls.Add(this.radioButtonCurrent);
            this.groupBoxInstall.Controls.Add(this.radioButtonAll);
            this.groupBoxInstall.Controls.Add(this.buttonInstall);
            this.groupBoxInstall.Location = new System.Drawing.Point(12, 558);
            this.groupBoxInstall.Name = "groupBoxInstall";
            this.groupBoxInstall.Size = new System.Drawing.Size(200, 85);
            this.groupBoxInstall.TabIndex = 2;
            this.groupBoxInstall.TabStop = false;
            this.groupBoxInstall.Text = "Install New Addin";
            // 
            // radioButtonCurrent
            // 
            this.radioButtonCurrent.AutoSize = true;
            this.radioButtonCurrent.Location = new System.Drawing.Point(93, 22);
            this.radioButtonCurrent.Name = "radioButtonCurrent";
            this.radioButtonCurrent.Size = new System.Drawing.Size(90, 19);
            this.radioButtonCurrent.TabIndex = 2;
            this.radioButtonCurrent.TabStop = true;
            this.radioButtonCurrent.Text = "Current User";
            this.radioButtonCurrent.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(5, 22);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(70, 19);
            this.radioButtonAll.TabIndex = 2;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All Users";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // comboBoxVersion
            // 
            this.comboBoxVersion.FormattingEnabled = true;
            this.comboBoxVersion.Location = new System.Drawing.Point(12, 30);
            this.comboBoxVersion.Name = "comboBoxVersion";
            this.comboBoxVersion.Size = new System.Drawing.Size(121, 23);
            this.comboBoxVersion.TabIndex = 3;
            this.comboBoxVersion.SelectedIndexChanged += new System.EventHandler(this.comboBoxVersion_SelectedIndexChanged);
            // 
            // groupBoxLang
            // 
            this.groupBoxLang.Controls.Add(this.radioButtonJP);
            this.groupBoxLang.Controls.Add(this.radioButtonTR);
            this.groupBoxLang.Controls.Add(this.radioButtonEN);
            this.groupBoxLang.Location = new System.Drawing.Point(718, 12);
            this.groupBoxLang.Name = "groupBoxLang";
            this.groupBoxLang.Size = new System.Drawing.Size(254, 49);
            this.groupBoxLang.TabIndex = 4;
            this.groupBoxLang.TabStop = false;
            this.groupBoxLang.Text = "Language / 言語";
            // 
            // radioButtonJP
            // 
            this.radioButtonJP.AutoSize = true;
            this.radioButtonJP.Location = new System.Drawing.Point(85, 22);
            this.radioButtonJP.Name = "radioButtonJP";
            this.radioButtonJP.Size = new System.Drawing.Size(61, 19);
            this.radioButtonJP.TabIndex = 0;
            this.radioButtonJP.TabStop = true;
            this.radioButtonJP.Text = "日本語";
            this.radioButtonJP.UseVisualStyleBackColor = true;
            this.radioButtonJP.CheckedChanged += new System.EventHandler(this.radioButtonLang_CheckedChanged);
            // 
            // radioButtonEN
            // 
            this.radioButtonEN.AutoSize = true;
            this.radioButtonEN.Location = new System.Drawing.Point(6, 22);
            this.radioButtonEN.Name = "radioButtonEN";
            this.radioButtonEN.Size = new System.Drawing.Size(63, 19);
            this.radioButtonEN.TabIndex = 0;
            this.radioButtonEN.TabStop = true;
            this.radioButtonEN.Text = "English";
            this.radioButtonEN.UseVisualStyleBackColor = true;
            this.radioButtonEN.CheckedChanged += new System.EventHandler(this.radioButtonLang_CheckedChanged);
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.Location = new System.Drawing.Point(12, 12);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(45, 15);
            this.labelVer.TabIndex = 5;
            this.labelVer.Text = "Version";
            // 
            // radioButtonTR
            // 
            this.radioButtonTR.AutoSize = true;
            this.radioButtonTR.Location = new System.Drawing.Point(163, 22);
            this.radioButtonTR.Name = "radioButtonTR";
            this.radioButtonTR.Size = new System.Drawing.Size(62, 19);
            this.radioButtonTR.TabIndex = 0;
            this.radioButtonTR.TabStop = true;
            this.radioButtonTR.Text = "Turkish";
            this.radioButtonTR.UseVisualStyleBackColor = true;
            this.radioButtonTR.CheckedChanged += new System.EventHandler(this.radioButtonLang_CheckedChanged);
            // 
            // AddinManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.labelVer);
            this.Controls.Add(this.groupBoxLang);
            this.Controls.Add(this.comboBoxVersion);
            this.Controls.Add(this.groupBoxInstall);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDisable);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.buttonNone);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.listViewValues);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddinManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revit Addin Manager";
            this.Load += new System.EventHandler(this.AddinManager_Load);
            this.groupBoxInstall.ResumeLayout(false);
            this.groupBoxInstall.PerformLayout();
            this.groupBoxLang.ResumeLayout(false);
            this.groupBoxLang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewValues;
        private System.Windows.Forms.ColumnHeader columnHeaderFile;
        private System.Windows.Forms.ColumnHeader columnHeaderFolder;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonNone;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Button buttonDisable;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.GroupBox groupBoxInstall;
        private System.Windows.Forms.RadioButton radioButtonCurrent;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.ComboBox comboBoxVersion;
        private System.Windows.Forms.GroupBox groupBoxLang;
        private System.Windows.Forms.RadioButton radioButtonJP;
        private System.Windows.Forms.RadioButton radioButtonEN;
        private System.Windows.Forms.Label labelVer;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.RadioButton radioButtonTR;
    }
}

