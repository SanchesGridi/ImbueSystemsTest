using ImbueSystemsTest.Database.Entities.Base;

namespace ImbueSystemsTest.Database.Entities;

public class Book : IEntity<int>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime PublishDateTime { get; set; }

    public virtual int AuthorId { get; set; }
    public virtual Author? Author { get; set; }
}
