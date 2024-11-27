using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class propertydetail
{
    public int id { get; set; }

    public string? sourceuniqueid { get; set; }

    public int? masterid { get; set; }

    public int profileid { get; set; }

    public string? propertyname { get; set; }

    public string? address { get; set; }

    public string? city { get; set; }

    public string? state { get; set; }

    public string? zipcode { get; set; }

    public double? latitude { get; set; }

    public double? longitude { get; set; }

    public string? containertype { get; set; }

    public DateOnly? createddate { get; set; }

    public DateOnly? modifieddate { get; set; }

    public int? countryid { get; set; }

    public int? regionid { get; set; }

    public string? referenceurl { get; set; }
}
