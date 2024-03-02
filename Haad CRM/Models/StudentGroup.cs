using Haad_CRM.Models.Common;

namespace Haad_CRM.Models;

public class StudentGroup:Auditable
{
    public int StudentId { get; set; }
    public int GroupId { get; set; }
}
