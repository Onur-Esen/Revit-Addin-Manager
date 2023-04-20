// بِسْــــــــــــــــــــــمِ اﷲِارَّحْمَنِ ارَّحِيم
// الْحَمْدُ لِلَّهِ رَبِّ الْعَالَمِينَ
// Allâhumme salli alâ seyyidinâ Muhammedin ve alâ âli seyyidinâ Muhammed
//
// (C) Copyright 2020 by Onur Esen

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Revit_Addin_Manager
{
    public partial class AddinManager : Form
    {
        string[] fileNames;
        string folderAdmin;
        string folderUser;
        string folderBundle;

        public AddinManager()
        {
            InitializeComponent();

            radioButtonAll.Checked = true;
            radioButtonEN.Checked = true;
            CancelButton = buttonClose;
            MaximizeBox = false;
        }

        private void AddinManager_Load(object sender, EventArgs e)
        {
            comboBoxVersion.DataSource = new List<string>() { "2019", "2020", "2021", "2022", "2023", "2024" };
            comboBoxVersion.SelectedIndex = 0;

            AddinListUpdate(listViewValues);
        }

        private void TurkishUI()
        {

        }

        private void JapaneseUI()
        {

        }

        private void AddinListUpdate(ListView listView)
        {
            try
            {
                listView.Items.Clear();

                string version = comboBoxVersion.SelectedItem as string;
                string user = Environment.UserName;
                folderAdmin = @"C:\ProgramData\Autodesk\Revit\Addins\" + version;
                folderUser = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+ @"\Autodesk\Revit\Addins\" + version;
                folderBundle = @"C:\ProgramData\Autodesk\ApplicationPlugins";

                if(Directory.Exists(folderAdmin))
                {
                    var enabledAdmin = Directory.GetFiles(folderAdmin, "*", SearchOption.TopDirectoryOnly).Where(x => x.EndsWith(".addin"));
                    var disableAdmin = Directory.GetFiles(folderAdmin, "*", SearchOption.TopDirectoryOnly).Where(x => x.EndsWith(".addin_"));
                    FileListView(listView, enabledAdmin, "Admin", System.Drawing.Color.White);
                    FileListView(listView, disableAdmin, "Admin", System.Drawing.Color.LightGray);
                }

                if (Directory.Exists(folderUser))
                {
                    var enableUser = Directory.GetFiles(folderUser, "*", SearchOption.TopDirectoryOnly).Where(x => x.EndsWith(".addin"));
                    var disableUser = Directory.GetFiles(folderUser, "*", SearchOption.TopDirectoryOnly).Where(x => x.EndsWith(".addin_"));
                    FileListView(listView, enableUser, "User", System.Drawing.Color.White);
                    FileListView(listView, disableUser, "User", System.Drawing.Color.LightGray);
                }

                if (Directory.Exists(folderBundle))
                {
                    var enabledBundle = Directory.GetDirectories(folderBundle, "*", SearchOption.TopDirectoryOnly).Where(x => x.EndsWith(".bundle"));
                    var disableBundle = Directory.GetDirectories(folderBundle, "*", SearchOption.TopDirectoryOnly).Where(x => x.EndsWith(".bundle_"));
                    BundleListView(listView, enabledBundle, "Bundle", System.Drawing.Color.White);
                    BundleListView(listView, disableBundle, "Bundle", System.Drawing.Color.LightGray);
                }

            }
            catch (Exception) { }
        }

        private void FileListView(ListView listView, IEnumerable<string> files, string folderType, System.Drawing.Color color)
        {
            foreach (string file in files)
            {
                var row = new string[] { Path.GetFileNameWithoutExtension(file), AddinInfo(file), folderType, file };
                var lvi = new ListViewItem(row);
                lvi.Tag = file;
                lvi.BackColor = color;
                listView.Items.Add(lvi);
            }
        }

        private void BundleListView(ListView listView, IEnumerable<string> files, string folderType, System.Drawing.Color color)
        {
            foreach (string file in files)
            {
                var row = new string[] { Path.GetFileName(file), "", folderType, file };
                var lvi = new ListViewItem(row);
                lvi.Tag = file;
                lvi.BackColor = color;
                listView.Items.Add(lvi);
            }
        }

        private void Install(string[] fileNames, string fileDest)
        {
            if (!Directory.Exists(fileDest))
                Directory.CreateDirectory(fileDest);

            foreach (string fileName in fileNames)
            {
                try
                {
                    string name = Path.GetFileName(fileName);

                    File.Copy(fileName, Path.Combine(fileDest, name), true);
                }
                catch (Exception) { }
            }
        }

        private string AddinInfo(string fileName)
        {
            if (true == File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    if (line.Contains("<Name>"))
                    {
                        return TextBetween(line, "<Name>", "</Name>");
                    }
                }
            }

            return "";
        }

        private string TextBetween(string text, string firstText, string lastText)
        {
            int pos0 = text.IndexOf(firstText) + firstText.Length;
            int pos1 = text.IndexOf(lastText);

            return text.Substring(pos0, pos1 - pos0);
        }

        private string Version(string file)
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(file);

            return versionInfo.FileVersion;
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            var selectedItems = listViewValues.SelectedItems;

            foreach (ListViewItem item in selectedItems)
            {
                string file = item.Tag as string;
                string fileNew = file.Remove(file.Length - 1);

                if (Path.GetExtension(file) == ".addin_")
                    File.Move(file, Path.ChangeExtension(file, "addin"));
                else if (Path.GetExtension(file) == ".bundle_")
                {
                    //if (!Directory.Exists(fileNew))
                    //    Directory.CreateDirectory(fileNew);

                    Directory.Move(file, fileNew);

                }
            }

            AddinListUpdate(listViewValues);
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            var selectedItems = listViewValues.SelectedItems;

            try
            {
                foreach (ListViewItem item in selectedItems)
                {
                    string file = item.Tag as string;
                    string extension = Path.GetExtension(file);
                    string fileNew = file + "_";

                    if (extension == ".addin")
                        File.Move(file, Path.ChangeExtension(file, "addin_"));
                    else if (extension == ".bundle")
                    {
                        //if (!Directory.Exists(fileNew))
                        //    Directory.CreateDirectory(fileNew);

                        Directory.Move(file, fileNew);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease run the Revit Addin Manager in admin mode", "Exception");
            }

            AddinListUpdate(listViewValues);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var selectedItems = listViewValues.SelectedItems;

            foreach (ListViewItem item in selectedItems)
            {
                string file = item.Tag as string;

                Process.Start("explorer.exe", "/select, \"" + file + "\"");
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewValues.Items)
            {
                item.Selected = true;
            }
        }

        private void buttonNone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewValues.Items)
            {
                item.Selected = true;
            }
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            // Logs
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();
            if (true == openFileDialog.CheckFileExists)
                fileNames = openFileDialog.FileNames;
            else return;

            string fileDest = folderAdmin;
            if (radioButtonCurrent.Checked)
                fileDest = folderUser;

            if (fileNames != null)
            {
                Install(fileNames, fileDest);
            }
            else
                MessageBox.Show("Please select files");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddinListUpdate(listViewValues);
        }

        private void radioButtonLang_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
