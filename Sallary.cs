using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Sallary : Form
    {
        public Sallary()
        {
            InitializeComponent();
            flowLayoutPanel1.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Salarydb", con);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed!", ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                int Emid = Convert.ToInt32(textBox1.Text);
                string name = textBox2.Text;
                string basicsalary = textBox3.Text;
                string allowance = textBox4.Text;
                string overtime = textBox5.Text;
                string salarymonth = comboBox1.Text;
                string year = comboBox2.Text;
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Salarydb( Emid,Name,Basic,Allowance,Overtime,Salary_Month,Year)VALUES(" + Emid + ",'" + name + "','" + basicsalary + "','" + allowance + "','" + overtime + "','" + salarymonth + "','" + year + "')", con);   
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Calculate Successfully...!");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("connection failed!", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Sallary_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("January");
            comboBox1.Items.Add("February");
            comboBox1.Items.Add("March");
            comboBox1.Items.Add("April");
            comboBox1.Items.Add("May");
            comboBox1.Items.Add("June");
            comboBox1.Items.Add("July");
            comboBox1.Items.Add("August");
            comboBox1.Items.Add("September");
            comboBox1.Items.Add("October");
            comboBox1.Items.Add("November");
            comboBox1.Items.Add("December");


            comboBox2.Items.Add(2025);
            comboBox2.Items.Add(2026);
            comboBox2.Items.Add(2027);
            comboBox2.Items.Add(2028);
            comboBox2.Items.Add(2029);
            comboBox2.Items.Add(2030);
            comboBox2.Items.Add(2031);
            comboBox2.Items.Add(2032);
            comboBox2.Items.Add(2033);
            comboBox2.Items.Add(2034);
            comboBox2.Items.Add(2035);
            comboBox2.Items.Add(2036);
            comboBox2.Items.Add(2037);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employeedb", con);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed!", ex.Message);


            }
            finally
            {
                con.Close();
            }
        }
    }
}
