namespace ImbueSystemsTest.Utils;

public static class TaskHelper
{
    public static uint GetSaturdaysCount(DateTime start, DateTime end)
    {
        if (end < start)
        {
            throw new InvalidOperationException("The start date must be less than the end date.");
        }
        var count = 0u;
        while (start.Date <= end.Date)
        {
            if (start.DayOfWeek == DayOfWeek.Saturday)
            {
                count++;
            }
            start = start.AddDays(1);
        }
        return count;
    }

    public static string GetArrayDuplicatesInformation<TEquatable>(TEquatable[] array) where TEquatable : IEquatable<TEquatable>
    {
        if (array == null)
        {
            throw new ArgumentNullException();
        }
        if (array.Length == 0)
        {
            throw new InvalidOperationException("Array was empty.");
        }
        var helper = new Dictionary<TEquatable, uint>();
        for (var index = 0; index < array.Length; index++)
        {
            var key = array[index];
            if (!helper.ContainsKey(key))
            {
                helper.Add(key, 1);
            }
            else
            {
                helper[key]++;
            }
        }
        var newLine = Environment.NewLine;
        return $"Results:{newLine}{string.Join(newLine, helper.Select(x => $"{x.Key}: {x.Value}"))}";
    }
}
