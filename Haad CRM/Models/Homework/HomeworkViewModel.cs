using Haad_CRM.Models.Group;

namespace Haad_CRM.Models.Homework;

public class HomeworkViewModel
{
    public long Id {  get; set; }
    public GroupViewModel Group { get; set; }
    public string HomeworkName { get; set; }
    public string HomeworkType { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public string Attachment { get; set; } // Changed to string
}