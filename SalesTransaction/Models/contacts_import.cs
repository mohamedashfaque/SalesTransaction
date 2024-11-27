using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class contacts_import
{
    public string? sourceuniqueid { get; set; }

    public int? masterid { get; set; }

    public int? profileid { get; set; }

    public string? brokerbompanyname { get; set; }

    public string? contactpersonname { get; set; }

    public string? phonenumber { get; set; }

    public string? email { get; set; }

    public string? referenceurl { get; set; }

    public string? comments { get; set; }

    public string? status { get; set; }

    public virtual propertydetails_import? profile { get; set; }
}
