namespace Haad_CRM.Models;

using System;
using Haad_CRM.Models.Common;

public class Payment:Auditable
{
    public int StudentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentStatus { get; set; }
}
