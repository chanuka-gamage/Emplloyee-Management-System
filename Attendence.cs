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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Attendence_Load(object sender, EventArgs e)
        {
           // comboBox1.Items.Add("Present");
            //comboBox1.Items.Add("Absent");

        }

        private void clear_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;
            dateTimePicker3.Checked = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "hh:mm tt";
            dateTimePicker3.ShowUpDown = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "hh:mm tt";
            dateTimePicker2.ShowUpDown = true;
        }

        private void view_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Attendencedb", con);
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

        private void attendance_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                int Emid = Convert.ToInt32(textBox1.Text);
                string name = textBox2.Text;
                DateTime checkin = dateTimePicker2.Value;
                DateTime date = dateTimePicker1.Value;
                string status = comboBox1.Text;
                DateTime checkout = dateTimePicker3.Value;

                con.Open();

                SqlCommand cmd = new SqlCommand(
 "INSERT INTO Attendencedb(EmId, Name, Check_In, Check_Out, date, Status) " +
 "VALUES(" + Emid + ",'" + name + "','" + checkin + "','" + checkout + "','" + date + "','" + status + "')",
 con);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data ADD Successfully...!");

                comboBox1.Items.Clear();
                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.Checked = false;
                dateTimePicker2.Checked = false;
                dateTimePicker3.Checked = false;

               


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

