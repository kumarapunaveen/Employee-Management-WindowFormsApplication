using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class SalaryData
    {
        public string EmployeeID { set; get; } //0
        public string Name { set; get; } //1
        public string Gender { set; get; } //2
        public string Contact { set; get; } //3

        public string Position { set; get; } //4
 
        public int Salary { set; get; } //5

        //connection to your database
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\navee\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        //working with salary
        public List<SalaryData> salaryemployeeListData()
        {
            List<SalaryData> listdata = new List<SalaryData>();


            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectdata = "SELECT * FROM employees WHERE status = 'Active' AND delete_date IS NULL ";

                    using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            SalaryData ed = new SalaryData();

                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contact = reader["contact_number"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Salary = (int)reader["salary"];

                            listdata.Add(ed);
                        }
                    }
                }
                catch (Exception e)
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
