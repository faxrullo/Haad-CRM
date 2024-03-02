namespace Haad_CRM.Models;

using System;

public class News
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishDate { get; set; }
    public bool IsRead { get; set; }
    public string Attachment { get; set; } // Changed to string
    public string AttachmentLink { get; set; }
}
