using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dialog_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult xx1 = colorDialog1.ShowDialog();
            if (xx1 == DialogResult.OK)
            {
                BackColor = this.colorDialog1.Color;
                btnColor.ForeColor = this.colorDialog1.Color;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = ("C:\\Users\\anast\\OneDrive\\Desktop\\C#\\2022").ToString();
            DialogResult xx2 = folderBrowserDialog1.ShowDialog();
            btnFolderBrowser.ForeColor = this.colorDialog1.Color;
            string fn;
            fn = folderBrowserDialog1.SelectedPath;
            //if(fn == "")
            if (xx2 == DialogResult.Cancel)
            {
                MessageBox.Show("Please select any folder");
                return;
            }
            else
            {
                textBox1.Text = fn;
            }
        }
        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            btnFolderBrowser.Font = fontDialog1.Font;
            btnColor.Font = fontDialog1.Font;
            textBox2.Text = fontDialog1.Font.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fn;
            fn = saveFileDialog1.FileName;
            txtDialog.Text = fn;
            
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show(openFileDialog1.Multiselect.ToString());

                if (!openFileDialog1.Multiselect)
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                else
                {
                    
                    foreach (String xx4 in openFileDialog1.FileNames)
                    {
                        //MessageBox.Show(xx4);
                        pictureBox1.Image = Image.FromFile(xx4);
                        Application.DoEvents(); // go zabavuva procesot na programata
                        Thread.Sleep(1000);// ja otvora sekoja slika posle edna sekunda
                    }

                }

            }
                
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}
