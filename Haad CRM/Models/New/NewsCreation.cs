﻿namespace Haad_CRM.Models.New;
using System;

public class NewsCreation
{
    public int StudentId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishDate { get; set; }
    public bool IsRead { get; set; }
    public string Attachment { get; set; } // Changed to string
    public string AttachmentLink { get; set; }
}
