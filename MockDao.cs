﻿using System;
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
                    Avatar = "Assets/avatar01.jpg"
                },
                new() {
                    ID = 2,
                    Name = "Jackie Bloude",
                    Avatar = "Assets/avatar02.jpg"
                },
                new() {
                    ID = 3,
                    Name = "Jason Claude",
                    Avatar = "Assets/avatar03.jpg",
                },
            };

        return result;
    }
}

