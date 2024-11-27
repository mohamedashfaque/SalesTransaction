using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class facility_import
{
    public string? sourceuniqueid { get; set; }

    public int? masterid { get; set; }

    public int? profileid { get; set; }

    public decimal? noofstories { get; set; }

    public decimal? numberofbuildings { get; set; }

    public decimal? parkingspaces { get; set; }

    public string? pads { get; set; }

    public decimal? parkingperunit { get; set; }

    public string? parkingratio { get; set; }

    public string? _class { get; set; }

    public string? acreage { get; set; }

    public bool? expansionpotential { get; set; }

    public decimal? occupancy { get; set; }

    public decimal? sqft { get; set; }

    public decimal? nrsf { get; set; }

    public decimal? totalunits { get; set; }

    public decimal? yearbuilt { get; set; }

    public string? referenceurl { get; set; }

    public string? comments { get; set; }

    public string? status { get; set; }

    public virtual propertydetails_import? profile { get; set; }
}
