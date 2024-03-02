namespace Haad_CRM.Models;

using System;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CourseId { get; set; }
    public int TeacherID { get; set; }
    public int ResourceId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string DaysOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}
