using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace myPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (diag_folder.ShowDialog() == DialogResult.OK)
            {
                txt_watchedFolder.Text = diag_folder.SelectedPath;
                if (txt_watchedFolder.Text != null)
                {
                    Properties.Settings.Default.watchedFolder = txt_watchedFolder.Text;
                    Properties.Settings.Default.Save();
                    toolStripStatusLabel2.Text = "Settings saved";
                }

            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txt_watchedFolder.Text))   
            {
                toolStripStatusLabel2.Text = "Starting watch...";
                tmr_watching.Enabled = true;
                btn_start.Enabled = false;
                btn_stop.Enabled = true;
            }
            else
            {
                button1_Click_1(sender, e);
                btn_start_Click(sender,e);
            }

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Ending watch...";
            tmr_watching.Enabled = false;
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
        }

         
        
        private void checkFolder(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(txt_watchedFolder.Text);
            FileInfo[] rgFiles = di.GetFiles("*.*");
            foreach (FileInfo fi in rgFiles)
            {
                string filetoprint = fi.FullName;
                
                //use the new PDF method if file is PDF
                if (fi.Extension.ToUpper() == "PDF")
                {
                    toolStripStatusLabel2.Text = "Printing PDF";
                    Pdf.PrintPdf(filetoprint);
                }

                //else use the normal method
                else
                {
                    toolStripStatusLabel2.Text = filetoprint;

                    Process printJob = new Process();
                    printJob.StartInfo.FileName = filetoprint;
                    printJob.StartInfo.UseShellExecute = true;
                    printJob.StartInfo.Verb = "print";
                    printJob.StartInfo.CreateNoWindow = true;
                    try
                    {
                        printJob.Start();
                        printJob.WaitForExit(1000 * 60 * 1);
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLabel2.Text = "Something went wrong...";
                    }
                    finally
                    {
                        printJob.Close();
                    }

                          
                }

                //Delete the file
                File.Delete(filetoprint);
                toolStripStatusLabel2.Text = "";
                
                        
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            //Load Settings
            txt_watchedFolder.Text = Properties.Settings.Default.watchedFolder;
            chk_watchOnStartup.Checked = Properties.Settings.Default.watchAtStartup;

            //if checkbox = true then start watch
            if (chk_watchOnStartup.Checked)
            {
                btn_start_Click(sender, e);
            }
        }

        private void chk_watchOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            //Update settings
            Properties.Settings.Default.watchAtStartup = chk_watchOnStartup.Checked;
            Properties.Settings.Default.Save();
            toolStripStatusLabel2.Text = "Settings saved";
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

       
    }
}
