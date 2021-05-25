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
namespace _5_21_file_2_wjy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text + "\\" + DateTime.Now.ToString("yyyyMMddhhmmss")+".txt";
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Create();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK){
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String path2 = "";
            FileInfo fileInfo = new FileInfo(textBox2.Text);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path2 = folderBrowserDialog1.SelectedPath;
                fileInfo.CopyTo(path2 + "\\" + fileInfo.Name+DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt");
            }
            
        }
    }
}
