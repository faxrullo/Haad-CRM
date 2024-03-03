namespace Haad_CRM.Models.Ball;

using Haad_CRM.Models.Common;
using System;

public class Ball : Auditable
{
    public int CoinMark { get; set; }
    public string Comment { get; set; }
    public int TotalCoin { get; set; }
}

