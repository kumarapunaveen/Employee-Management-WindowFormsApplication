using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//to complete signup button
using System.Data;
using System.Data.SqlClient; //these two are imported to work with sql completely

namespace EmployeeManagementSystem
{
    public partial class RegisterForm: Form
    {
        //creates connevction to your local sql server
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\users\navee\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;"); //the path is the connection string we can see in propoerties of database employye.mdf
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_signinbtn_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1(); //when we click on sign in it should redirect to login form so create instance for that
            loginform.Show();
            this.Hide();
        }

        private void signup_showpass_CheckedChanged(object sender, EventArgs e) //here the signup_password is the name of the textbox we can see in the properties
        {
            signup_password.PasswordChar = signup_showpass.Checked ? '\0' : '*'; //to display password when we click chekbox show password
        }

        private void signup_btn_Click(object sender, EventArgs e) //working with signup button
        {
            if(signup_username.Text == "" || signup_password.Text == "") //checks if username or password is empty or not
            {
                MessageBox.Show("please fill all the blank fields","error message", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else //if not empty
            {
                //check if the database connection is not currently open
                if(connect.State != ConnectionState.Open)  //State property tells CURRENT STATUS of connection
                {
                    try //write code
                    {
                        connect.Open(); //opening the database connection first

                        //to check if the user with same username  Existed already or not

                        string selectusername = "SELECT COUNT(id) FROM users WHERE username = @user";  //we are storing the sql commmand(query) in string type variable

                        //create a sqlcommand named checkuser that will  run the query on the database connection connect and automatically clean it up after the use
                        using(SqlCommand chekcuser = new SqlCommand(selectusername , connect)) //runing the query - first parameter is sql query , second parameter isdatabase connection
                        {
                            //adds a PARAMETER to sql command checkuser
                            chekcuser.Parameters.AddWithValue("@user", signup_username.Text.Trim()); //takes uname entered in txt box without spaces at start, end and give it to sql query as value of @user
                            int count = (int)chekcuser.ExecuteScalar();

                            if(count >= 1) //more than 1 user with same username
                            {
                                MessageBox.Show(signup_username.Text.Trim() + "is already taken","Error Message",  MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else //insert data into database table
                            {
                                DateTime today = DateTime.Today; //current date without time

                                //insert query
                                string insertdata = "INSERT INTO users (username , password , date_register) VALUES(@username , @password , @datereg)"; //storing sql query in string variable                                  


                                //command cmd that will run insert query using database connection 'connect'
                                using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                                {
                                    //adding value to placeholder in the query
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@datereg", today);

                                    cmd.ExecuteNonQuery(); // executes command that doesnot returns any data

                                    //display popup mesage to confirm the user was registered succcesfully
                                    MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //redirect to login form
                                    Form1 loginform = new Form1();
                                    loginform.Show();
                                    this.Hide();

                                }
                            }
                        }
                        
                    }
                    catch(Exception ex) //handles the exception if raises , if no error in try block catch will not be executed
                    {
                        MessageBox.Show("Error : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close(); //clsoing the database connection at last
                    }
                }
            }
        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
