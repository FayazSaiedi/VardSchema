using VardSchema.Api.Models;

namespace VardSchema.Tests;

public class WorkShiftTests
{
    [Fact]
    public void DayShiftShouldHaveEightHoursAndThirtyMinutesWorkingTime()
    {
        var shift = new WorkShift
        {
            Type = ShiftType.Day,
            StartsAt = new DateTime(2026, 9, 10, 6, 45, 0),
            EndsAt = new DateTime(2026, 9, 10, 15, 45, 0),
            BreakMinutes = 30
        };

        TimeSpan result = shift.CalculateWorkingDuration();

        Assert.Equal(TimeSpan.FromHours(8.5), result);
    }
    [Fact]
    public void NightShiftShouldHandleCrossingMidnight() 
    {
        var shift = new WorkShift
        {
            Type = ShiftType.Night,
            StartsAt = new DateTime(2026, 9, 10, 20, 15, 0),
            EndsAt = new DateTime(2026, 9, 11, 7, 0, 0),
            BreakMinutes = 0
        };

        TimeSpan result = shift.CalculateWorkingDuration();
        Assert.Equal(TimeSpan.FromHours(10.75), result);
    }
}