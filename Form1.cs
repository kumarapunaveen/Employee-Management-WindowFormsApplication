using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//to work with login button of login page
using System.Data;
using System.Data.SqlClient;


namespace EmployeeManagementSystem
{
    public partial class Form1: Form
    {
        //connnection to our local server
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\users\navee\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;"); //the path is the connection string we can see in propoerties of database employye.mdf

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupbtn_Click(object sender, EventArgs e)
        {
            RegisterForm regform = new RegisterForm(); //we want to redirect to Registerform when we click on signup so we have to create instance for that form or page
            regform.Show(); //it displays that registration form
            this.Hide();  //it hides current form/page  which is login form
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e) //to show password
        {
            login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e) //working with login button in login page
        { //code checks uname and pwd from login form, validates them against the database

            if(login_username.Text == "" || login_password.Text == "") //username and password should not be empty
            {
                MessageBox.Show("please fill all the blank fields", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else //if both are filled then
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open(); //opening database connection

                        string selectdata = "SELECT * FROM users WHERE username=@username and password = @password"; //fetching user with entered details

                        using(SqlCommand cmd = new SqlCommand(selectdata,connect)) //holding the query and connection
                        {
                            //replacing @uname , @pwd with actual entered values in the textbox
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                            //running query and stroing result
                            //we have row of data so we neeed something that can read rows - so we are using SqlDataAdapter class

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd); //or we can use ExecuteReader()
                            //it is used to fetch the data from db and  fill it into a dataTable or other data structures
                            DataTable table = new DataTable();
                            adapter.Fill(table); //filling the data into table

                            if(table.Rows.Count >= 1) //checks if atleast one row exists in the result
                            {
                                MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //redirect to main form after successfull login

                                MainForm mform = new MainForm();
                                mform.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                
            }
        }
    }
}
