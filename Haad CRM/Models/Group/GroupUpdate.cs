namespace Haad_CRM.Models.Group;

using System;

public class GroupUpdate
{
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
