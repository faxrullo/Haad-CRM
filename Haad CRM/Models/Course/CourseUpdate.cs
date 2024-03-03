namespace Haad_CRM.Models.Course;

using System;

public class CourseUpdate
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }
    public DateTime StartDate { get; set; }
    public int Price { get; set; }
    public DateTime EndDate { get; set; }
    public int MaxEnrollment { get; set; }
}
