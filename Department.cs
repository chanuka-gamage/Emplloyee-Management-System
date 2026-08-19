using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace forms
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
            flowLayoutPanel1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void Department_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con=new SqlConnection(conString);

            try
            {
                int id = Convert.ToInt32(textBox1.Text);
                string Department = textBox2.Text;
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Departmentdb(id,Department )VALUES(" + id + ",'" + Department + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data ADD Successfully...!");

                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect Failed!", ex.Message);
                MessageBox.Show(ex.ToString(), "Database ERROR");
            }
            finally { 
            con.Close();
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);
            flowLayoutPanel1.Visible= true;

            try { 
            con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Departmentdb", con);
                cmd.CommandType= CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt=new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource= dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
            }
            catch(Exception ex) {
                MessageBox.Show("connect failed!",ex.Message);
            }
            finally {
                con.Close();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                string delete = textBox1.Text;
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM [Employeedb] WHERE EMId=" + delete, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully...!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "connection failed");
            }
            finally { con.Close(); }
        }
    }
    }

