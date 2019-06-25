using System.Data.Entity;

namespace FirstApp.Models
{
	public class BookContext : DbContext
	{
		public DbSet<Book> Books { get; set; }

		public DbSet<Purchase> Purchases { get; set; }
	}

	public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
	{
		protected override void Seed(BookContext db)
		{
			db.Books.Add(new Book { Name = "War and Peace", Author = "L.Tolstoyi", Price = 220 });
			db.Books.Add(new Book { Name = "Sons and fathers", Author = "I.Turgeniev", Price = 180 });
			db.Books.Add(new Book { Name = "Owl", Author = "A.Chehov", Price = 150 });
			base.Seed(db);
		}
	}
}