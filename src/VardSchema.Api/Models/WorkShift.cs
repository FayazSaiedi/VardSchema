namespace VardSchema.Api.Models;

public class WorkShift
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public ShiftType Type { get; set; }

    public DateTime StartsAt { get; set; }

    public DateTime EndsAt { get; set; }

    public int BreakMinutes { get; set; }

    public TimeSpan CalculateWorkingDuration()
    {
        TimeSpan totalDuration = EndsAt - StartsAt;
        TimeSpan breakDuration = TimeSpan.FromMinutes(BreakMinutes);

        return totalDuration - breakDuration;
    }
}
