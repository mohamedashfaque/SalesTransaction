using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class user
{
    public int id { get; set; }

    public string? username { get; set; }

    public string? email { get; set; }

    public string? password { get; set; }

    public int? employeeid { get; set; }

    public int? usertypeid { get; set; }

    public int? createdby { get; set; }

    public DateTime? createddate { get; set; }

    public virtual lookupusertype? usertype { get; set; }
}
