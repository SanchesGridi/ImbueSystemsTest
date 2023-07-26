using ImbueSystemsTest.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImbueSystemsTest.Database.Contexts;

public class LibraryContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var now = DateTime.Now;

        var author1 = new Author
        {
            Id = 1,
            Name = "A1"
        };
        var author2 = new Author
        {
            Id = 2,
            Name = "A2"
        };
        var author3 = new Author
        {
            Id = 3,
            Name = "A3"
        };
        var author4 = new Author
        {
            Id = 4,
            Name = "A4"
        };

        var book1 = new Book
        {
            Id = 1,
            AuthorId = author1.Id,
            Name = "A1_1st_book",
            PublishDateTime = now.AddYears(-3)
        };
        var book2 = new Book
        {
            Id = 2,
            AuthorId = author1.Id,
            Name = "A1_2nd_book",
            PublishDateTime = now.AddYears(-1)
        };
        var book3 = new Book
        {
            Id = 3,
            AuthorId = author2.Id,
            Name = "A2_1st_book",
            PublishDateTime = now.AddYears(-5)
        };
        var book4 = new Book
        {
            Id = 4,
            AuthorId = author2.Id,
            Name = "A2_2nd_book",
            PublishDateTime = now.AddYears(-1)
        };
        var book5 = new Book
        {
            Id = 5,
            AuthorId = author3.Id,
            Name = "A3_1st_book",
            PublishDateTime = now.AddYears(-7)
        };
        var book6 = new Book
        {
            Id = 6,
            AuthorId = author4.Id,
            Name = "A4_1st_book",
            PublishDateTime = now.AddYears(-4)
        };

        modelBuilder.Entity<Author>().HasData(author1, author2, author3, author4);
        modelBuilder.Entity<Book>().HasData(book1, book2, book3, book4, book5, book6);
    }
}