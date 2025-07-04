using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e) //working with logout button of main form
        {
            DialogResult check = MessageBox.Show("Are you sure You want to Logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes) //if we click yes button
            {
                //redirect to login page
                Form1 loginform = new Form1();
                loginform.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e) //working with dashboard button of main form
        {
            dashboard1.Visible = true; //when we click on dashboard then dashboard is visible on rightside panel
            addEmployee1.Visible = false;
            salary1.Visible = false;


            // after workng with update buttonn of salary page

            //used to refresh data immediately when we do modifications
            Dashboard dashForm = dashboard1 as Dashboard;
            if(dashForm != null)
            {
                dashForm.RefreshData();
            }
        }

        private void addEmployee_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;


            //
            AddEmployee addemForm = addEmployee1 as AddEmployee;
            if(addemForm != null)
            {
                addemForm.RefreshData();
            }
        }

        private void salary_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;


            //
            Salary salaryForm = salary1 as Salary;
            if(salaryForm != null)
            {
                salaryForm.RefreshData();
            }
        }
    }
}
