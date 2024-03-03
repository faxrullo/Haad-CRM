namespace Haad_CRM.Models.Payment;

using Haad_CRM.Models.Common;
using System;

public class Payment : Auditable
{
    public int StudentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentStatus { get; set; }
}
