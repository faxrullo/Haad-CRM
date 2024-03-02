namespace Haad_CRM.Models.Lesson;

using System;

public class Lesson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int GroupId { get; set; }
    public DateTime LFromDate { get; set; }
    public DateTime LToDate { get; set; }
}
