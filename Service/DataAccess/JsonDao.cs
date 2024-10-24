using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoListBinding1610;
public class JsonDao : IDao
{
    public List<Employee> GetEmployees()
    {
        var result = new List<Employee>();
        string json = """
                    [
            {
            "ID": 7,
            "Name": "Trần Văn An",
            "Avatar":  "/Assets/avatar04.jpg"
            },
            {
            "ID": 8,
            "Name": "Nguyễn Thị Bình",
            "Avatar": "/Assets/avatar05.jpg"
            },
            {
            "ID": 9,
            "Name": "Lê Quyết Chiến",
            "Avatar": "/Assets/avatar06.jpg"
            }
        ]
        """;
        
        result = JsonSerializer.Deserialize<List<Employee>>(json);
        return result;
    }
}
