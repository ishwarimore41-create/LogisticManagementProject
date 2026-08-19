using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticManagementProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Dashboard dash;
        private Form1 form1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Prajakta" || textBox2.Text == "123")
            {
                MessageBox.Show("You are logged in successfully..");
                this.Visible = false;
                Dashboard obj1 = new Dashboard();
                obj1.ShowDialog();
                textBox1.Text = "";
                textBox1.Text = "";
                form1 = new Form1();
                form1.Close();
                dash = new Dashboard();
                dash.Show();

            }
            else
                MessageBox.Show("Invalid Username Or Password");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0'; //Display as plain text
            }
            else
            {
                textBox2.PasswordChar = '*'; //Display as password(masked)
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
