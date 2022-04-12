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

namespace Final643450075_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "400";          
            textBox5.Text = "20";
            textBox7.Text = "380";



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string allDATARAW = readAllLine[i];
                    string[] allDATASplited = allDATARAW.Split(',');
                    this.dataGridView1.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2]);
                }
            }
        }
    }
}
