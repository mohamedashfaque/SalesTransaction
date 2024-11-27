using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class lookupusertype
{
    public int id { get; set; }

    public string? name { get; set; }

    public virtual ICollection<user> users { get; set; } = new List<user>();
}
