namespace Haad_CRM.Models.Payment;

using System;

public class PaymentUpdate
{
    public int StudentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentStatus { get; set; }
}
