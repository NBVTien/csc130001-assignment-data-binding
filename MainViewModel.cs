using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListBinding1610;
public class MainViewModel
{
    public List<Employee> Employees
    {
        get; set;
    }

    public MainViewModel()
    {
        IDao dao = new MockDao();
        Employees = dao.GetEmployees();
    }

    
}
