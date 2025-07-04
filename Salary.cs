using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//
using System.Data;
using System.Data.SqlClient;


namespace EmployeeManagementSystem
{
    public partial class Salary: UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\navee\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public Salary()
        {
            InitializeComponent();

            displayEmployees(); //calling the method to display data  in gridview first when we open salary page

            disableFields(); //followed by disabling fields


        }


        //
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployees();
            disableFields();
        }



        //method to disable fiields
        public void disableFields()
        {
            salary_employeeid.Enabled = false; //now we cnt update or delete
            salary_name.Enabled = false;
            salary_position.Enabled = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //working with salary page
        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.salaryemployeeListData();

            dataGridView1.DataSource = listData; //to display data in grid
        }

        private void salary_updt_btn_Click(object sender, EventArgs e) //update button of salary - third part
        {
            if(salary_employeeid.Text == "" || salary_name.Text == "" || salary_position.Text == "" || salary_salary.Text == "")
            {
                MessageBox.Show("Pls fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Employee ID : " + salary_employeeid.Text.Trim() + "?" , "Conformation Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(check == DialogResult.Yes)
                {
                    if(connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            //updating salary

                            string updateData = "UPDATE employees SET salary = @salary , update_date = @updatedate WHERE employee_id = @employeeid";
                            using(SqlCommand cmd = new SqlCommand(updateData,connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", salary_salary.Text.Trim());
                                cmd.Parameters.AddWithValue("@updatedate", today);
                                cmd.Parameters.AddWithValue("@employeeid", salary_employeeid.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayEmployees(); //displaying details in the grid view after updating data

                                MessageBox.Show("Updated Successfully", "Informmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //data in text boxes should be cleared after updating
                                clearFields(); 
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        
        public void clearFields() //method to clearfields -  4th part
        {
            salary_employeeid.Text = "";
            salary_name.Text = "";
            salary_position.Text = "";
            salary_salary.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //to display data from grid to left side text boxes which is second part
        {
            if(e.RowIndex != -1) //checking if the clicked row index is valid 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; //getting the cicked row from the datagriidview
                //assignng values to textfields
                salary_employeeid.Text = row.Cells[0].Value.ToString();
                salary_name.Text = row.Cells[1].Value.ToString();
                salary_position.Text = row.Cells[4].Value.ToString();
                salary_salary.Text = row.Cells[5].Value.ToString();
            }
        }


        //workng with clear button
        private void salary_clr_btn_Click(object sender, EventArgs e) //5th part
        {
            clearFields();  //calling clearfields of method to clear data in text boxes
        }
    }
}
