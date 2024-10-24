using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinRT;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DemoListBinding1610;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get; set;
    }
    public MainPage()
    {
        this.InitializeComponent();
        ViewModel = new MainViewModel();
        // DataContext = this;
    }
    private void getAllCategoriesButton_Click(object sender, RoutedEventArgs e)
    {
    }

    private void addCategoryButton_Click(object sender, RoutedEventArgs e)
    {
        ViewModel.Employees.Add(new Employee()
        {
            ID = 6,
            Name = "Jason Claude 9",
            Avatar = "/Assets/avatar09.jpg"
        });
    }

    private void deleteCategoryButton_Click(object sender, RoutedEventArgs e)
    {
        var employee = itemsComboBox.SelectedItem as Employee;
        ViewModel.Employees.Remove(employee);
    }

    private void updateCategoryButton_Click(object sender, RoutedEventArgs e)
    {
        var employee = itemsComboBox.SelectedItem as Employee;
        employee.ID = 999;
        employee.Name = "Jason Claude 999";
        employee.Avatar = "/Assets/avatar10.jpg";
    }

    private void replaceCategoryButton_Click(object sender, RoutedEventArgs e)
    {
        ViewModel.Employees = new FullObservableCollection<Employee>()
        {
            new Employee()
            {
                ID = 171,
                Name = "Jason Bourne",
                Avatar = "/Assets/avatar07.jpg"
            },
            new Employee()
            {
                ID = 172,
                Name = "Jason Statham",
                Avatar = "/Assets/avatar08.jpg"
            },
            new Employee()             {
                ID = 173,
                Name = "Jason Momoa",
                Avatar = "/Assets/avatar09.jpg"
            },
        };
    }
}
