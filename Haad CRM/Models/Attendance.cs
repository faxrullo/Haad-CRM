namespace Haad_CRM.Models;

using System;

public class Attendance
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int GroupId { get; set; }
    public DateTime AttendanceDate { get; set; }
    public string Status { get; set; }
}
