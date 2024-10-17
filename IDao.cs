using System.Collections.Generic;
using Week04.Helpers;

namespace Week04
{
	public interface IDao
	{
		List<Book> GetBooks();
	}
}
