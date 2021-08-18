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
using Microsoft.VisualBasic;
using WMPLib;
namespace show_directories
{
    public partial class Form1 : Form
    {
        string showPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drivesName = Directory.GetLogicalDrives();
            comboBoxDirectory.Items.AddRange(drivesName);
        }
        private void show(string getShowPath)
        {
           
            listBox1.Items.Clear();

            try
            {
                string[] directories = Directory.GetDirectories(getShowPath);
                string[] files = Directory.GetFiles(getShowPath);
                listBox1.Items.AddRange(directories);
                listBox1.Items.AddRange(files);
                adressBar.Text = getShowPath;
            }
            catch
            {
                MessageBox.Show("SOME THING WENT WRONG");
                
            }
           
        }
            
        private void comboBoxDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPath = comboBoxDirectory.Text;
            show(showPath);
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
            showPath = listBox1.Text;
            if (Directory.Exists(showPath))
                show(showPath);
            else
            {
                try
                {
                    string[] fileName = listBox1.Text.Split('.');
                    int lastindex = fileName.Length - 1;
                    string fileNameLastIndex = fileName[lastindex];
                    if (fileNameLastIndex == "mp3" || fileNameLastIndex == "mp4" || fileNameLastIndex == "mkv")
                    {
                        axWindowsMediaPlayer1.Visible = true;
                        closeMedia.Visible = true; 
                        axWindowsMediaPlayer1.URL = listBox1.Text;
                    }
                    else if (fileNameLastIndex == "jpg" || fileNameLastIndex == "png")
                    {
                        pictureBox1.Visible = true;
                        closePic.Visible = true;
                        pictureBox1.ImageLocation = listBox1.Text;
                    }
                    else if ( fileNameLastIndex == "txt")
                    {
                        showTxtFile.Visible = true;
                        closeTxt.Visible = true;
                        string fileContent = File.ReadAllText(listBox1.Text);
                        showTxtFile.Text = fileContent;
                    }
                }
                catch { }
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string PreviousAddress = Directory.GetParent(adressBar.Text).FullName;
                show(PreviousAddress);
            }
            catch { }
            
                
        }
        private void newBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string getNewFileName = Interaction.InputBox("WRITE NEW FOLDER NAME", "new folder", "NEW FOLDER");
                Directory.CreateDirectory(adressBar.Text +"\\"+ getNewFileName);
                show(adressBar.Text);
            }
            catch { }
        }
        private void moveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                folderBrowserDialog1.ShowDialog();
                string[] fileName = listBox1.Text.Split('\\');
                int lastindex = fileName.Length - 1;
                string fileNameLastIndex = fileName[lastindex];
                if (Directory.Exists(listBox1.Text))
                {
                    Directory.Move(listBox1.Text, folderBrowserDialog1.SelectedPath + '\\' + fileNameLastIndex);
                    
                }
                else
                {
                    File.Move(listBox1.Text, folderBrowserDialog1.SelectedPath + '\\' + fileNameLastIndex);
                }
                showPath = adressBar.Text;
                show(showPath);
            }
            catch { MessageBox.Show("SOME THING WENT WRONG"); }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
             DialogResult sure =  MessageBox.Show("ARE YOU SURE ???" , "DELETE" , MessageBoxButtons.YesNo);
             if (sure == DialogResult.Yes)
             {
                 if (Directory.Exists(listBox1.Text))
                     Directory.Delete(listBox1.Text, true);
                 else
                     File.Delete(listBox1.Text);
                 showPath = adressBar.Text;
                 show(showPath);
             }
            
            }
            catch { MessageBox.Show("SOME THING WENT WRONG"); }
          
        }

        private void closeMedia_Click(object sender, EventArgs e)
        {
            closeMedia.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Visible = false;
        }

        private void closePic_Click(object sender, EventArgs e)
        {
            closePic.Visible = false;
            pictureBox1.Visible = false;
        }

        private void closeTxt_Click(object sender, EventArgs e)
        {
            closeTxt.Visible = false;
            showTxtFile.Visible = false;
            
        }

    }
}
