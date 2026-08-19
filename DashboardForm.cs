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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();


            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conString);
             conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employeedb", conn);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            empdetailsgrid.DataSource = dt;



        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            dashboardForm.Hide();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            Emplyee em=new Emplyee();
            em.Show();
            this.Hide();

           
        }

        private void department_Click(object sender, EventArgs e)
        {
            Department dp=new Department();
            dp.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lgin = new Login();
            lgin.Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            about a=new about();
            a.Show();
            this.Hide();
        }

        private void attendence_Click(object sender, EventArgs e)
        {
            Attendence attendence=new Attendence();
            attendence.Show();
            this.Hide();

        }

        private void sallary_Click(object sender, EventArgs e)
        {
            Sallary sallary=new Sallary();
            sallary.Show();
            this.Hide();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            Report re=new Report();
            re.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void empdetailsgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
