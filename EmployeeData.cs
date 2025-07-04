using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using System.Data;
using System.Data.SqlClient;

//EmployeeData.cs is a MODEL CLASS to represent employees data structure in c#
//it maps each row of the employees database table into a C# obbject. It allows us to work with Employees data in strongly typed 
//way instead of raw database rows . it easily fetch,manipulate,display employee data in your application

namespace EmployeeManagementSystem
{
    class EmployeeData //class
    {
        //properties of the class, representing columns of  employee table
        public int ID { set; get; } //0
        public string EmployeeID { set; get; } //1
        public string Name { set; get; } //2
        public string Gender { set; get; } //3
        public string Contact { set; get; } //4
        public string Position { set; get; } //5
       public string Image { set; get; } //6
        public int Salary { set; get; } //7
       public string Status { set; get; } //8


        //connection to your database
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\navee\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
   
        public List<EmployeeData> employeeListData() //method , returns LIST of EmployeeData Objects
        { //this method fetch  all the employees from the database


            //create an empty list that will store employee objects
            List<EmployeeData> listdata = new List<EmployeeData>();

            //open connection and prepare query
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectdata = "SELECT * FROM employees WHERE delete_date IS NULL "; //sql query to get active Employees

                    using(SqlCommand cmd = new SqlCommand(selectdata,connect))
                    {
                        //SqlDataREader is used to READ Data from sql server database ROW by ROW
                        SqlDataReader reader = cmd.ExecuteReader(); //it executes a sql query  and returns SqlDataReader, this reader is then used to loop through rows

                        //loop through each row
                        while(reader.Read())
                        {
                            EmployeeData ed = new EmployeeData(); //creates new EmployeeData object(instance) to hold current row data

                            //maps database columns to the Object properties
                            //means assigning each columns value to the corresponding property of the object

                            ed.ID = (int)reader["id"]; //left side are variables in this code and right side are cols of employees table
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contact = reader["contact_number"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Image = reader["image"].ToString();
                            ed.Salary = (int)reader["salary"];
                            ed.Status = reader["status"].ToString();

                            //adding this employee object to the list
                            listdata.Add(ed);
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Erro : " + e);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata; //returning list of all employee objects fetched
        }
    }
}
