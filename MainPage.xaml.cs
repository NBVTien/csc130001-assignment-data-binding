using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;
using Week04.Helpers;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Week04
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public class MainViewModel
		{
			public List<Book> CurrentBooks
			{
				get; set;
			}
		}

		public MainViewModel ViewModel { get; set; }

		public MainPage()
		{
			this.InitializeComponent();

			ViewModel = new MainViewModel
			{
				CurrentBooks = new MockDao().GetBooks()
			};
		}
	}
}
