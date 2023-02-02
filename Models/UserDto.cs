namespace ScheduleAPI.Models;

public record struct UserDto
{
    public int UserId {get; set; }
    public string Name { get; set; }
}