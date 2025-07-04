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
using System.Data.SqlClient;
using System.IO;

namespace EmployeeManagementSystem
{
    public partial class AddEmployee: UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\navee\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public AddEmployee()
        {
            InitializeComponent();

            //To display data from your database to your data grid view
            displayEmployeeData();
        }



        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;              
            }
            displayEmployeeData();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void displayEmployeeData() //method to show list of employees inside a grid view
        {
            //calls method from employeedata.cs to get employee list

            EmployeeData ed = new EmployeeData(); //instance creation for the class
            List<EmployeeData> listdata = ed.employeeListData(); //calling method employeeListData using the Instance

            dataGridView1.DataSource = listdata; //showing employee data in grid
        }

        private void addemp_addd_Click(object sender, EventArgs e) //working with ADD button of AddEmployee form
        {
            if (addEmp_id.Text == "" || addemp_fullname.Text == "" || addemp_gender.Text=="" || addemp_phnumber.Text ==""
                || addemp_position.Text =="" || addemp_status.Text == "" ||  addemp_picture.Image == null)
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else //if all details are entered
            {
                if(connect.State != ConnectionState.Open) //checking database connection is open or not
                {
                    try
                    {
                        connect.Open();

                        //duplicate check
                        //string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id=@emID"; //returns count of how many records already exist in table with same employee_id
                        //modifying above query after working with delete button
                        string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID AND delete_date IS NULL"; //now if we add same id which is deleted earlier will be added
                        using (SqlCommand checkEm = new SqlCommand(checkEmID,connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addEmp_id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar(); //it is used when we want to retrieve single value from database

                            if(count >= 1) //means the employee with provided id is  alreadey existed in database employees
                            {
                                MessageBox.Show(addEmp_id.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else //new employee
                            {
                                DateTime tod = DateTime.Today;

                                string insertData = "INSERT INTO  employees (employee_id,full_name,gender,contact_number,position" +
                                    ", image,salary,insert_date,status) VALUES(@employeeID,@fullname,@gender,@contactnum,@position" +
                                    ", @image,@salary,@insertdate,@status)";

                                //fow saving the image we get after clicking import button, into our database
                                //new folder named (Directory) is created and writing down this below code now
                                //complete image path
                                string path = Path.Combine(@"D:\practice\EmployeeManagementSystem\EmployeeManagementSystem\Directory\" 
                                            + addEmp_id.Text.Trim() + ".jpg" ); //full file path where image will be saved on our disk

                                //if we are 100% sure that our directory is existed then we can skip this part and directly copy the image
                                string directoryPath = Path.GetDirectoryName(path); //extracting folder path i.e Directory Path
                                if(!Directory.Exists(directoryPath)) //if directory path not exists , create it
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }


                                File.Copy(addemp_picture.ImageLocation, path, true); //copying the image into our path



                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addEmp_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullname", addemp_fullname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addemp_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactnum",addemp_phnumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addemp_position.Text.Trim());

                                    cmd.Parameters.AddWithValue("@image", path); //our path is saved in the database image coulum

                                    cmd.Parameters.AddWithValue("@salary",0);
                                    //cmd.Parameters.AddWithValue("@salary", addEmp_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insertdate", tod);
                                    cmd.Parameters.AddWithValue("@status", addemp_status.Text.Trim());

                                    cmd.ExecuteNonQuery(); //it innserts data into database

                                    displayEmployeeData(); //after inserting this method is used to refresh data grid view on form, shwoing updated list of employees
                                    
                                    MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                  
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro : "+ex , "Error Message" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addemp_import_Click(object sender, EventArgs e) //working with import Button
        { //code to get the image into PictureBox when we click on import
           //then that image should be saved in database for that we have written code at the top


            try
            {
                OpenFileDialog dialog = new OpenFileDialog(); //allows useers to browse their file system
                //filter to allow image with specific extensions
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg; *.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK) //showdialog() method returns value of type DialogResult that tells how dialog was closed
                {
                    imagePath = dialog.FileName;   //get selected file path
                    addemp_picture.ImageLocation = imagePath; //set image location to show in the PictureBox
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex,"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //by clickig on the cellclick of datagridview1
        { //when we click onn cell of datagrid view then data will be visible in the form down
            //not deleted employees data will be visible
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmp_id.Text = row.Cells[1].Value.ToString();
                addemp_fullname.Text = row.Cells[2].Value.ToString();
                addemp_gender.Text = row.Cells[3].Value.ToString();
                addemp_phnumber.Text = row.Cells[4].Value.ToString();
                addemp_position.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if(imagePath != null)
                {
                    addemp_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addemp_picture.Image = null;
                }


                 addemp_status.Text = row.Cells[8].Value.ToString();
            }
        }

        public void clearFields() //method written after working with update button
        { //method to clear the fields
            addEmp_id.Text = "";
            addemp_fullname.Text = "";
            addemp_gender.SelectedIndex = -1; //as it is a combobox
            addemp_phnumber.Text = "";
            addemp_position.SelectedIndex = -1;
            addemp_status.SelectedIndex = -1;
            addemp_picture.Image = null;
        }
        private void addemp_updt_Click(object sender, EventArgs e) //working with update buttonn of addemployee.cs
        { 
            if (addEmp_id.Text == "" || addemp_fullname.Text == "" || addemp_gender.Text == "" || addemp_phnumber.Text == ""
                || addemp_position.Text == "" || addemp_status.Text == "" || addemp_picture.Image == null)  //before clicking on update button every field should not be blank
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else //if all details are entered then
            {
                //when we click on update then first it will be displayed
                DialogResult check = MessageBox.Show("Are you sure you want to Update " +
                    "Employee_ID:" + addEmp_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(check == DialogResult.Yes) //if yes then details will be updated
                {
                    try
                    {
                        connect.Open();

                        DateTime tod = DateTime.Today;

                        //new entered details should be Updated
                        string updateData = "UPDATE employees SET full_name = @fullname, gender = @gender,contact_number = @contactnum , position = @position,update_date = @updatedate " +
                            ",status = @status WHERE employee_id = @employeeid";

                        using(SqlCommand cmd = new SqlCommand(updateData,connect))
                        {
                            cmd.Parameters.AddWithValue("@fullname", addemp_fullname.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addemp_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactnum", addemp_phnumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", addemp_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@updatedate", tod);
                            cmd.Parameters.AddWithValue("@status", addemp_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeid", addEmp_id.Text.Trim());

                            cmd.ExecuteNonQuery();
                            displayEmployeeData();
                            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void addemp_clr_Click(object sender, EventArgs e) //working with clear button
        {
            clearFields(); // all details are cleared
        }

        private void addemp_dlt_Click(object sender, EventArgs e) //working with delete button
        {
            if (addEmp_id.Text == "" || addemp_fullname.Text == "" || addemp_gender.Text == "" || addemp_phnumber.Text == ""
               || addemp_position.Text == "" || addemp_status.Text == "" || addemp_picture.Image == null)  //before clicking on update button every field should not be blank
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else //if all details are entered then
            {
                //when we click on delete button then first it will be displayed
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee_ID:" + addEmp_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes) //if yes then details will be updated
                {
                    try
                    {
                        connect.Open();

                        DateTime tod = DateTime.Today;


                        string updateData = "UPDATE employees SET delete_date = @deletedate WHERE employee_id = @employeeid"; //set delete date - means updating delete_date column

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deletedate",tod);
                            cmd.Parameters.AddWithValue("@employeeid", addEmp_id.Text.Trim());

                            //when we click delete button it is deleted from grid but still its present in the  database employees
                            //and when we add another employee with same id  , it will not be added even though we deleted earlier
                            //so modify add query in the code above
                            

                            cmd.ExecuteNonQuery();
                            displayEmployeeData(); //now data will not be displayed because data is displayed only when delete_date is null, but here its not null
                            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
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
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
