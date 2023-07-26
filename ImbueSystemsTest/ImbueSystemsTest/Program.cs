using ImbueSystemsTest.Database.Contexts;
using Microsoft.EntityFrameworkCore;

using static ImbueSystemsTest.Utils.TaskHelper;
using static ImbueSystemsTest.Utils.SqlConsts;

// 1st task:
var start = new DateTime(2023, 6, 23);
var end = new DateTime(2023, 7, 20);
var count = GetSaturdaysCount(start, end);
Console.WriteLine($"1) Saturdays: {count}");

// 2nd task:
var array = new int[] { 1, 2, 5, 3, 2, 4, 5, 6, 2, 1, 4, 6, 6, 6, 7, 1, 3, 4 };
var result = GetArrayDuplicatesInformation(array);
Console.WriteLine($"2) {result}");

// 5th task:
var context = new LibraryContext(
    new DbContextOptionsBuilder<LibraryContext>().UseSqlServer(Connection).UseLazyLoadingProxies().Options
);
Console.WriteLine($"Authors count: {context.Authors.Count()}");
Console.WriteLine($"Books count: {context.Books.Count()}");
var authors = context.Authors.FromSqlRaw(Query).Include(x => x.Books);
Console.WriteLine("Results:");
foreach (var author in authors)
{
    Console.WriteLine(
        $"Id: {author.Id}; Name: {author.Name}; Books: {string.Join(", ", author.Books.Select(x => x.Name))}"
    );
}