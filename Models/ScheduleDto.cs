namespace ScheduleAPI.Models;

public record struct ScheduleDto
{
    public int UserId {get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Interval { get; set; }
    public TimeOnly Time { get; set; }
}