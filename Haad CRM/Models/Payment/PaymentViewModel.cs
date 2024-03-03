namespace Haad_CRM.Models.Payment;

using Haad_CRM.Models.Student;
using System;

public class PaymentViewModel
{
    public long Id {  get; set; }
    public StudentViewModel Student { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentStatus { get; set; }
}