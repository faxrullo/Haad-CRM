namespace Haad_CRM.Models;

using System;
using Haad_CRM.Models.Common;

public class Attendance:Auditable
{
    public int StudentId { get; set; }
    public int GroupId { get; set; }
    public DateTime AttendanceDate { get; set; }
    public string Status { get; set; }
}
