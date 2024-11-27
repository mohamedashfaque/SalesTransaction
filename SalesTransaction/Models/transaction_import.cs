using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class transaction_import
{
    public string? sourceuniqueid { get; set; }

    public int? masterid { get; set; }

    public int? profileid { get; set; }

    public DateOnly? datelisted { get; set; }

    public DateOnly? datesold { get; set; }

    public bool? confidential { get; set; }

    public double? listingprice { get; set; }

    public double? salepricepublicsource { get; set; }

    public double? salepriceselfreported { get; set; }

    public bool? partofportfolio { get; set; }

    public decimal? portfoliopercentage { get; set; }

    public int? saletypeid { get; set; }

    public double? caprate { get; set; }

    public decimal? noi { get; set; }

    public double? priceperunit { get; set; }

    public double? pricepersqft { get; set; }

    public string? descriptionexecutivesummary { get; set; }

    public string? investmenthighlights { get; set; }

    public string? referenceurl { get; set; }

    public string? comments { get; set; }

    public string? status { get; set; }

    public virtual propertydetails_import? profile { get; set; }

    public virtual lookupsalestype? saletype { get; set; }
}
