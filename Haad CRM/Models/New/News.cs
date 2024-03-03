namespace Haad_CRM.Models.New;

using Haad_CRM.Models.Common;
using System;

public class News : Auditable
{
    public int StudentId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishDate { get; set; }
    public bool IsRead { get; set; }
    public string Attachment { get; set; } // Changed to string
    public string AttachmentLink { get; set; }
}
