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
    public partial class Dashboard: UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\navee\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public Dashboard()
        {
            InitializeComponent();

            //calling the methods
            displayTE();
            displayAE();
            displayIE();
        }


        // to refresh data
        public void RefreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayTE(); //displaying new  data after  refreshing/modifying
            displayAE();
            displayIE();
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void displayTE() //method to display Total Employees
        {
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    //counting ids
                    string selectData = "SELECT COUNT(id) FROM employees WHERE delete_date IS NULL"; //not deleted employees data!!
                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader(); //returns result in a SqlDataReader
                        if(reader.Read()) //it reads the result
                        {
                            int count = Convert.ToInt32(reader[0]); //reader[0] contaiins the count of employees
                            dash_te.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error :" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {

            }
        }


        public void displayAE() //method to display Active Employees
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    //counting ids
                    string selectData = "SELECT COUNT(id) FROM employees WHERE status = @status AND delete_date IS NULL"; //not deleted employees data!!
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dash_ae.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {

            }
        }


        public void displayIE() //method to display InActive Employees
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    //counting ids
                    string selectData = "SELECT COUNT(id) FROM employees WHERE status = @status AND delete_date IS NULL"; //not deleted employees data!!
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dash_ie.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {

            }
        }
    }
}
