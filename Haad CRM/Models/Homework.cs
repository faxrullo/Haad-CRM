using Haad_CRM.Models.Common;

namespace Haad_CRM.Models;

public class Homework:Auditable
{
    public int GroupId { get; set; }
    public string HomeworkName { get; set; }
    public string HomeworkType { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public string Attachment { get; set; } // Changed to string
}
