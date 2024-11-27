using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class transaction
{
    public int id { get; set; }

    public string? sourceuniqueid { get; set; }

    public int? masterid { get; set; }

    public int? profileid { get; set; }

    public DateOnly? createddate { get; set; }

    public DateOnly? modifieddate { get; set; }

    public DateOnly? datelisted { get; set; }

    public string? datesold { get; set; }

    public bool? confidential { get; set; }

    public double? listingprice { get; set; }

    public double? salepricepublicsource { get; set; }

    public double? salepriceselfreported { get; set; }

    public bool? partofportfolio { get; set; }

    public decimal? portfoliopercentage { get; set; }

    public string? saletype { get; set; }

    public double? caprate { get; set; }

    public decimal? noi { get; set; }

    public string? seller { get; set; }

    public string? buyer { get; set; }

    public double? priceperunit { get; set; }

    public double? pricepersqft { get; set; }

    public int? countryid { get; set; }

    public int? regionid { get; set; }

    public string? descriptionexecutivesummary { get; set; }

    public string? investmenthighlights { get; set; }

    public string? referenceurl { get; set; }
}
