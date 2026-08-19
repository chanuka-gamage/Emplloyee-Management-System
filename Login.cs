using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "2004" && textBox2.Text == "1234")
            {
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                errorProvider1.SetError(textBox1, "Name Recuired");
                errorProvider2.SetError(textBox2, "Name Recuired");
                MessageBox.Show("Your ID or Password Incorrect.\n" +
                                "Please, Try Again...!");
                textBox1.Clear();
                textBox2.Clear();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
