using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class propertydetails_import
{
    public int? rvparkid { get; set; }

    public int? masterid { get; set; }

    public int profileid { get; set; }

    public string? propertyname { get; set; }

    public string? address { get; set; }

    public string? city { get; set; }

    public string? state { get; set; }

    public string? zipcode { get; set; }

    public double? latitude { get; set; }

    public double? longitude { get; set; }

    public string? referenceurl { get; set; }

    public string? comments { get; set; }

    public string? status { get; set; }
}
