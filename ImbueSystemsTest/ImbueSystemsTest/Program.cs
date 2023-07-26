using static ImbueSystemsTest.Utils.TaskHelper;

// 1st task:
var start = new DateTime(2023, 6, 23);
var end = new DateTime(2023, 7, 20);
var count = GetSaturdaysCount(start, end);
Console.WriteLine($"1) Saturdays: {count}");