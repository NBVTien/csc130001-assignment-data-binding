using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DemoListBinding1610;
public class SqlServerDao : IDao
{
    public List<Employee> GetEmployees()
    {
        var result = new List<Employee>();

        var connectionString = """
            Server=localhost;
            Database=supershop;
            User Id=sa;
            Password=SqlServer@123;
            TrustServerCertificate=True;
        """;
        var connection = new SqlConnection(connectionString);
        connection.Open();

        var sql = "SELECT * FROM Employee";
        var command = new SqlCommand(sql, connection);
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var employee = new Employee(); // Relation -> Objects
            
            employee.ID = (int)reader["ID"];
            employee.Name = (string) reader["Name"];
            employee.Avatar = (string) reader["Avatar"];

            result.Add(employee);
        }

        connection.Close();
        return result;
    } 
}
