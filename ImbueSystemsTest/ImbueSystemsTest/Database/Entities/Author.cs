using ImbueSystemsTest.Database.Entities.Base;

namespace ImbueSystemsTest.Database.Entities;

public class Author : IEntity<int>
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
