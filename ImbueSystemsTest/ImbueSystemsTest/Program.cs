using static ImbueSystemsTest.Utils.TaskHelper;

// 1st task:
var start = new DateTime(2023, 6, 23);
var end = new DateTime(2023, 7, 20);
var count = GetSaturdaysCount(start, end);
Console.WriteLine($"1) Saturdays: {count}");
// 2nd task:
var array = new int[] { 1, 2, 5, 3, 2, 4, 5, 6, 2, 1, 4, 6, 6, 6, 7, 1, 3, 4 };
var result = GetArrayDuplicatesInformation(array);
Console.WriteLine($"2) {result}");