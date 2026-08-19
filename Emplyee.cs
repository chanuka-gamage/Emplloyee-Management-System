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
using System.Data.SqlClient;

namespace forms
{
    public partial class Emplyee : Form
    {
        public Emplyee()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            flowLayoutPanel1.Visible = false;
            
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con=new SqlConnection(conString);

            

            try {
                int Emid = Convert.ToInt32(emplooyeet.Text);
                string name=namet.Text;
                string email=emailt.Text;
                string phone=phonet.Text;
                string department=comboBox1.Text;
                string salary=salaryt.Text;
                string position=positiont.Text;
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Employeedb( Emid,name,email,phone,department, salary,position)VALUES(" + Emid + ",'"+ name+ "','"+ email + "','"+ phone + "','"+ department + "','" + salary + "','"+ position + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Add Successfully...!");

                namet.Clear();
                emailt.Clear();
                phonet.Clear();
                positiont.Clear();
                salaryt.Clear();
                emplooyeet.Clear();
                comboBox1.Items.Clear();

            }
            catch(Exception ex) { 
            MessageBox.Show("connection failed!",ex.Message);
            }
            finally {
                con.Close();

            }
        }

        private void Emplyee_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("IT");
            comboBox1.Items.Add("HR");
            comboBox1.Items.Add("Finance");
            comboBox1.Items.Add("Marketing");
            
        }

        private void view_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            string conString=Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employeedb", con);
                cmd.CommandType= CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                namet.Clear();
                emailt.Clear();
                phonet.Clear();
                positiont.Clear();
                salaryt.Clear();
                emplooyeet.Clear();
                comboBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed!", ex.Message);
                

            }
            finally { 
                con.Close();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            namet.Clear();
            emailt.Clear();
            phonet.Clear();
            positiont.Clear();
            salaryt.Clear();
            emplooyeet.Clear();
            comboBox1.Items.Clear();
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
        }

        private void searchpannel_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;

            if (!int.TryParse(textBox7.Text.Trim(), out int Emid))
            {
                MessageBox.Show("Please enter a valid numeric Employee ID.");
                return;
            }

            using (var con = new SqlConnection(conString))
            using (var cmd = new SqlCommand("SELECT name, email FROM Employeedb WHERE Emid = @Emid", con))
            {
                cmd.Parameters.Add("@Emid", SqlDbType.Int).Value = Emid;
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox1.Text = reader["name"]?.ToString() ?? "";
                        textBox2.Text = reader["email"]?.ToString() ?? "";
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
            }
        }

        private void emplooyeet_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString =Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try {
                string delete = textBox3.Text;
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM [Employeedb] WHERE EMId="+delete,con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully...!");
            }
            catch(Exception ex){
            MessageBox.Show(ex.Message,"connection failed");
            }
            finally { con.Close(); }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
