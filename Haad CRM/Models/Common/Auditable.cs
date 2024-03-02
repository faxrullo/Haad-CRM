using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haad_CRM.Models.Common;

public abstract class Auditable
{
    public long Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreateAt{get;set;} = DateTime.UtcNow;
    public DateTime UpdateAt{get;set;}
    public DateTime DeletedAt{get;set;}


}
