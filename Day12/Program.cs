using Microsoft.Data.SqlClient;
using System.Data;

namespace Day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=.;Initial Catalog=RouteCompany;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;


            #region Connected Mode

            //sqlConnection.Open();

            #region ExcuteQuery
            //sqlCommand.CommandText = "SELECT * FROM Employee";

            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //while(sqlDataReader.Read())
            //{
            //int ID = sqlDataReader.GetInt32(0); // EmployeeId
            //string FName = sqlDataReader.GetString(1); // FirstName
            //string LName = sqlDataReader.GetString(2); // LastName
            //int DeptID = sqlDataReader.GetInt32(3); // DepartmentId
            //int Salary = sqlDataReader.GetInt32(4); // Salary

            //int ID = (int)sqlDataReader[0];
            //string FName = (string)sqlDataReader["EmpFname"];
            //string LName = (string)sqlDataReader[2];
            //int DeptID = (int)sqlDataReader["DeptNo"];
            //int Salary = (int)sqlDataReader[4];

            //Console.WriteLine($"ID: {ID}, First Name: {FName}, Last Name: {LName}, Department ID: {DeptID}, Salary: {Salary}");
            //}
            #endregion

            #region ExcuteScalar

            //sqlCommand.CommandText = "SELECT COUNT(*) FROM Employee";

            //int count = (int)sqlCommand.ExecuteScalar();

            //Console.WriteLine($"Total Employees: {count}"); 

            #endregion

            #region ExecuteNonQuery
            //sqlCommand.CommandText = "INSERT INTO Employee (EmpNo,EmpFname, EmpLname, DeptNo, Salary) VALUES (1234,'John', 'Doe', 1, 50000)";

            //int rowsAffected = sqlCommand.ExecuteNonQuery();

            //Console.WriteLine($"{rowsAffected} row(s) inserted.");
            #endregion

            #region Procedures

            //sqlCommand.CommandText = "exec GetAllEmployees";
            //int id = 1234;
            //sqlCommand.CommandText = $"exec GetEmployeeById {id}";

            //sqlCommand.CommandText = "GetAllEmployees";
            //sqlCommand.CommandText = "GetEmployeeById";
            //sqlCommand.CommandText = "GetEmployeeNameById";
            //sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //sqlCommand.Parameters.AddWithValue("@id", 1234);

            //SqlParameter sqlIDParameter = new SqlParameter("@id",1234);
            //sqlCommand.Parameters.Add(sqlIDParameter);

            //ParameterDirection direction = ParameterDirection.Output;
            //SqlParameter sqlNameParameter = new SqlParameter("@name", SqlDbType.VarChar, 50)
            //{
            //Direction = direction
            //};
            //sqlCommand.Parameters.Add(sqlNameParameter);

            //sqlCommand.ExecuteNonQuery();

            //string employeeName = (string)sqlCommand.Parameters["@name"].Value;
            //string employeeName = sqlNameParameter.SqlValue.ToString();
            //string employeeName = sqlNameParameter.Value.ToString();
            //Console.WriteLine($"Employee Name:{employeeName}");

            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //while (sqlDataReader.Read())
            //{
            //    int ID = sqlDataReader.GetInt32(0); // EmployeeId
            //    string FName = sqlDataReader.GetString(1); // FirstName
            //    string LName = sqlDataReader.GetString(2); // LastName
            //    int DeptID = sqlDataReader.GetInt32(3); // DepartmentId
            //    int Salary = sqlDataReader.GetInt32(4); // Salary
            //    Console.WriteLine($"ID: {ID}, First Name: {FName}, Last Name: {LName}, Department ID: {DeptID}, Salary: {Salary}");
            //}



            #endregion

            //sqlConnection.Close();

            #endregion

            #region Disconnected Mode

            //sqlCommand.CommandText = "SELECT * FROM Employee";

            //SqlDataAdapter adapter = new SqlDataAdapter(); // open|close connection, execute query

            //adapter.SelectCommand = sqlCommand;
                                
            //DataTable dataTable = new DataTable();

            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    int ID = (int)row[0];
            //    string FName = (string)row["EmpFname"];
            //    string LName = (string)row[2];
            //    int DeptID = (int)row["DeptNo"];
            //    int Salary = (int)row[4];

            //    Console.WriteLine($"ID: {ID}, First Name: {FName}, Last Name: {LName}, Department ID: {DeptID}, Salary: {Salary}");

            //}

            #endregion
        }
    }
}
