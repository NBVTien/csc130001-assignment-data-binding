using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListBinding1610;
public class MainViewModel: INotifyPropertyChanged
{
    public FullObservableCollection<Employee> Employees
    {
        get; set;
    }

    public MainViewModel()
    {
        IDao dao = new MockDao();
        Employees = new FullObservableCollection<Employee>(dao.GetEmployees());
    }

    public event PropertyChangedEventHandler PropertyChanged;
}
