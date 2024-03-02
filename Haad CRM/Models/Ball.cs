namespace Haad_CRM.Models;

using System;
using Haad_CRM.Models.Common;

public class Ball:Auditable
{
    public int CoinMark { get; set; }
    public string Comment { get; set; }
    public DateTime Created_at { get; set; }
    public int TotalCoin { get; set; }
}
