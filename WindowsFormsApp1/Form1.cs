using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Login_Form : System.Windows.Forms.Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool name=false; 
            bool pass=false;

            if (txt.Text.Equals("Waseem")) 
            {
                name = true;
            }
            if (passwordtxt.Text.Equals("Waseem"))
            {
                pass = true;
            }

            switch (name&&pass)
            {
                case true:
                    HomePage_Form frm = new HomePage_Form();
                    frm.ShowDialog();
                    break;
                case false:
                    MessageBox.Show("Invalid data");
                    break;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            groupBox1.ForeColor = Color.White;



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            groupBox1.ForeColor= Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showHidebtn_Click(object sender, EventArgs e)
        {
            if (passwordtxt.UseSystemPasswordChar == false)
            {
                passwordtxt.UseSystemPasswordChar = true; 
            }
            else passwordtxt.UseSystemPasswordChar = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
