using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class contact
{
    public int id { get; set; }

    public string? sourceuniqueid { get; set; }

    public int? masterid { get; set; }

    public int? storeid { get; set; }

    public DateOnly? createddate { get; set; }

    public DateOnly? modifieddate { get; set; }

    public string? brokerbompanyname { get; set; }

    public string? contactpersonname { get; set; }

    public string? phonenumber { get; set; }

    public string? email { get; set; }

    public int? countryid { get; set; }

    public int? regionid { get; set; }

    public string? referenceurl { get; set; }
}
