using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListBinding1610;
public class MockDao : IDao
{
    public List<Employee> GetEmployees()
    {
        var result = new List<Employee>() {
                new() {
                    ID = 1,
                    Name = "John Algabi",
                    Avatar = "/Assets/avatar01.jpg"
                },
                new() {
                    ID = 2,
                    Name = "Jackie Bloude",
                    Avatar = "/Assets/avatar02.jpg"
                },
                new() {
                    ID = 3,
                    Name = "Jason Claude",
                    Avatar = "/Assets/avatar03.jpg",
                },
                new() {
                    ID = 4,
                    Name = "Jason Claude  4",
                    Avatar = "/Assets/avatar04.jpg",
                },
                 new() {
                    ID = 5,
                    Name = "Jason Claude 5",
                    Avatar = "/Assets/avatar05.jpg",
                },
            };

        return result;
    }
}

