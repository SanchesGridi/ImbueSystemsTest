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
}
