namespace Haad_CRM.Models.Teacher;

using System;

public class Teacher
{
    public long ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
}
