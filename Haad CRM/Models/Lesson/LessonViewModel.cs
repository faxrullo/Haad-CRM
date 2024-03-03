namespace Haad_CRM.Models.Lesson;

using Haad_CRM.Models.Group;
using System;

public class LessonViewModel
{
    public long Id { get; set; }
    public string Name { get; set; }
    public GroupViewModel Group { get; set; }
    public DateTime LFromDate { get; set; }
    public DateTime LToDate { get; set; }
}