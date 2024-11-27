using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class facility
{
    public int id { get; set; }

    public string? sourceuniqueid { get; set; }

    public int? masterid { get; set; }

    public int? profileid { get; set; }

    public DateOnly? createddate { get; set; }

    public DateOnly? modifieddate { get; set; }

    public int? noofstories { get; set; }

    public int? numberofbuildings { get; set; }

    public int? parkingspaces { get; set; }

    public int? boatspaces { get; set; }

    public int? rvspaces { get; set; }

    public int? cc { get; set; }

    public string? _class { get; set; }

    public double? acreage { get; set; }

    public string? expansionpotential { get; set; }

    public string? parkingratio { get; set; }

    public double? clearceilingheight { get; set; }

    public string? amenities { get; set; }

    public int? occupancy { get; set; }

    public long? sqft { get; set; }

    public long? nrsf { get; set; }

    public int? totalunits { get; set; }

    public int? yearbuilt { get; set; }

    public int? countryid { get; set; }

    public int? regionid { get; set; }

    public string? referenceurl { get; set; }

    public string? comments { get; set; }
}
