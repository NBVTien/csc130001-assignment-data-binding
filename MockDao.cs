using System.Collections.Generic;
using Week04.Helpers;

namespace Week04
{
	public class MockDao : IDao
	{
		public List<Book> GetBooks()
		{
			return new List<Book>
			{
				new Book {Name = "The Great Escape", CoverImageSource = "Assets/Images/the_great_escape.jpg", Author = "John Smith", PublishedYear = 2006, ISBN = "978-163874999"},
				new Book {Name = "Mystery at the Manor", CoverImageSource = "Assets/Images/mystery_at_the_manor.jpg", Author = "Emily Stone", PublishedYear = 2004, ISBN = "978-124307033"},
				new Book {Name = "Space Odyssey", CoverImageSource = "Assets/Images/space_odyssey.png", Author = "James Carter", PublishedYear = 2014, ISBN = "978-308339788"},
				new Book {Name = "Code of Shadows", CoverImageSource = "Assets/Images/the_code_of_shadows.png", Author = "Sophia Williams", PublishedYear = 2011, ISBN = "978-277551188"},
				new Book {Name = "Rise of the Phoenix", CoverImageSource = "Assets/Images/rise_of_the_phoenix.jpg", Author = "Liam Brown", PublishedYear = 1988, ISBN = "978-313801766"},
				new Book {Name = "The Final Countdown", CoverImageSource = "Assets/Images/the_final_countdown.jpg", Author = "Olivia Johnson", PublishedYear = 2021, ISBN = "978-503332687"},
				new Book {Name = "Echoes of Eternity", CoverImageSource = "Assets/Images/echoes_of_eternity.jpg", Author = "Noah Davis", PublishedYear = 1993, ISBN = "978-598264758"},
				new Book {Name = "The Lost Kingdom", CoverImageSource = "Assets/Images/the_lost_kingdom.jpg", Author = "Isabella Moore", PublishedYear = 2001, ISBN = "978-960221525"},
				new Book {Name = "Whispers in the Dark", CoverImageSource = "Assets/Images/whispers_in_the_dark.jpg", Author = "Mason Wilson", PublishedYear = 1994, ISBN = "978-994293631"},
				new Book {Name = "The Infinite Horizon", CoverImageSource = "Assets/Images/the_infinite_horizon.jpg", Author = "Emma Thompson", PublishedYear = 2020, ISBN = "978-802801337"}
			};
		}
	}
}
