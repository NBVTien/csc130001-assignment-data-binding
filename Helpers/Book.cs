using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.Helpers;

public class Book : INotifyPropertyChanged 
{
    public string Name { get; set; }
    public string CoverImageSource { get; set; }
    public string Author { get; set; }
    public int PublishedYear { get; set; }
    public string ISBN { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;
}
