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

namespace FileBrowser
{
    public partial class Form1 : Form
    {
        private string folder = @"D:\";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowFolderContents();
        }

        private void ShowFolderContents()
        {
            lbxFiles.Items.Clear();
            var folders = Directory.GetDirectories(folder);
            foreach (var folder in folders)
            {
                lbxFiles.Items.Add(folder);
            }

            var files = Directory.GetFiles(folder);
            foreach (var file in files)
            {
                lbxFiles.Items.Add(file);
            }

        }

        private void lbxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (string)lbxFiles.SelectedItem;
            FileAttributes attr = File.GetAttributes(selectedItem);
            if (attr.HasFlag(FileAttributes.Directory))
            {
                lblOutput.Text = "Folder selected";
                btnOpenFolder.Enabled = true;
            }
            else
            {
                lblOutput.Text = "File selected";
                btnOpenFolder.Enabled = false;
            }

                
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            var selectedItem = (string)lbxFiles.SelectedItem;
            folder = selectedItem;
            ShowFolderContents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filename = @"D:\SWeko\Books\Calibre\Henry Louis Gates Jr_\Stony the Road (4708)\Stony the Road - Henry Louis Gates Jr_.mobi";

            //Console.WriteLine("Begin reading");
            var contents = File.ReadAllLines(filename);
            //Console.WriteLine($"Total lines: {contents.Length}");
            //Console.WriteLine($"Total characters: {contents.Sum(line => line.Length)}");
            //Console.WriteLine("Finished reading");
        }
    }
}
