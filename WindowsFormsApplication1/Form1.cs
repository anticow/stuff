using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class mainForm : Form
    {
        public class folderObj
        {
            public string Folder { get; set; }
            public string Folderparent { get; set; }
            public string Fullpath { get; set; }

            public folderObj(string folder, string folderparent, string fullpath)
            {
                Folder = folder;
                Folderparent = folderparent;
                Fullpath = fullpath;

            }
        }
        public mainForm()
        {
            InitializeComponent();

        }

        private void mainForm_Load_1(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
            //FolderBrowserDialog folder = new FolderBrowserDialog();
            //this.folder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            folder.SelectedPath = System.IO.Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            folder.ShowNewFolderButton = false;
            DialogResult result = this.folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                // the code here will be executed if the user presses Open in
                // the dialog.
                string foldername = folder.SelectedPath;
                foreach (string f in Directory.GetFiles(foldername)) this.listBox1.Items.Add(f);  
                listBox2.Items.Add(foldername);
                Object foldername_object = new Object();
                foldername_object = foldername;
                
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void folderdig(object sender, EventArgs e)
        {
            //collect all of the subdirectory information
            //if ( ) {};

            //do stuff, develop the path for the target directory

            //collect all of the direct files in the current sub directory

            //do stuff, see how many files there are, if blank move on to the next up and create the new end path for the function

        }
    }
}
