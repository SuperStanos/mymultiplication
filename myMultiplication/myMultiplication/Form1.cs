using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myMultiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = string.Empty;

            try
            {

                for (int i = 1; i <= int.Parse(this.comboBox1.Text); i++)
                {
                    for (int x = 1; x <= int.Parse(this.comboBox2.Text); x++)
                    {
                        this.textBox1.Text = string.Concat(this.textBox1.Text, (i * x), "\t");

                    }
                    this.textBox1.Text = string.Concat(this.textBox1.Text, "\r\n");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            for (int a = 1; a <= 15; a++)
            {
                this.comboBox1.Items.Add(a);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            this.comboBox2.Items.Clear();
            for (int b = 1; b <= 15; b++)
            {
                this.comboBox2.Items.Add(b);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://borgy-basic-programming.blogspot.com");
        }
    }
}
