namespace ImbueSystemsTest.Utils;

public static class SqlConsts
{
    public const string Connection =
        "Server=(LocalDB)\\MSSQLLocalDB;Database=library_db;Trusted_Connection=True";
    public const string Query =
        "select * from Authors where Authors.Id not in (select Books.AuthorId from Books where DATEDIFF(year, Books.PublishDateTime, GETDATE()) <= 2)";
}
