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
using UnicornManaged;
using UnicornManaged.Const;
using System.Diagnostics;

namespace EmuClone
{
    public partial class Form1 : Form
    {
        public static String file_name = "Untitled.asm";
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void btnNew_Click(object sender, EventArgs e)
        {       
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnEmulate_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("iexplore", "https://yassinebridi.github.io/asm-docs/");
            }
            catch { 
            }

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutClonaEmu f3 = new AboutClonaEmu();
            f3.ShowDialog();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            // string readfile = File.ReadAllText(filename);
            //richTextBox1.Text = readfile;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Browse Files";
            openFileDialog1.DefaultExt = "asm";
            openFileDialog1.Filter = "asm files (*.asm)|*.asm|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                file_name = openFileDialog1.FileName;
                string file_text = File.ReadAllText(file_name);
                richTextBox1.Text = file_text;
                label1.Text = file_name;                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {        
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Files";
            //saveFileDialog1.CheckFileExists = true;
            //saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "asm";
            saveFileDialog1.Filter = "ASM files (*.asm)|*.asm|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_name = saveFileDialog1.FileName;
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                {
                    using(StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(richTextBox1.Text);
                        sw.Close();
                        s.Close();
                        label1.Text = file_name;
                    }
                }

            }
        }

        private void btnExamples_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "bits 32\nMOV ECX, 1\nINC ECX\nDEC EDX";        
        }

        private void btnNeutilizat_Click(object sender, EventArgs e)
        {
     
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f10 = new Form1();
            f10.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Browse Files";
            openFileDialog1.DefaultExt = "asm";
            openFileDialog1.Filter = "asm files (*.asm)|*.asm|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                file_name = openFileDialog1.FileName;
                string file_text = File.ReadAllText(file_name);
                richTextBox1.Text = file_text;
                label1.Text = file_name;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Files";
            //saveFileDialog1.CheckFileExists = true;
            //saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "asm";
            saveFileDialog1.Filter = "ASM files (*.asm)|*.asm|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_name = saveFileDialog1.FileName;
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(richTextBox1.Text);
                        sw.Close();
                        s.Close();
                        label1.Text = file_name;
                    }
                }

            }
        }

        private void HelpStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("iexplore", "https://yassinebridi.github.io/asm-docs/");
            }
            catch { }
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutClonaEmu f3 = new AboutClonaEmu();
            f3.ShowDialog();
        }

        private void emulator_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Examples_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "bits 32\nMOV ECX, 1\nINC ECX\nDEC EDX";
        }

        private void showEmulator_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void exitStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
