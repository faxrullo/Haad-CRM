namespace Haad_CRM.Models;

using System;

public class Payment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentStatus { get; set; }
}
