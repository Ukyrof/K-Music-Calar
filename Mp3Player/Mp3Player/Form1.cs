using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] dosyalar, path;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                dosyalar = openFileDialog1.SafeFileNames;
                path = openFileDialog1.FileNames;
                for (int i = 0; i < dosyalar.Length; i++)
                {
                    listBox1.Items.Add(dosyalar[i]);
                }
            }
            
        }
    }
}
