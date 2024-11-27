using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class deedinformations_import
{
    public string? sourceuniqueid { get; set; }

    public int? masterid { get; set; }

    public int? profileid { get; set; }

    public decimal? transactionyear { get; set; }

    public string? book { get; set; }

    public string? page { get; set; }

    public DateOnly? dateofdeed { get; set; }

    public string? deedtype { get; set; }

    public string? deednumber { get; set; }

    public string? deeddescription { get; set; }

    public string? grantor { get; set; }

    public string? grantee { get; set; }

    public double? saleprice { get; set; }

    public string? referenceurl { get; set; }

    public string? comments { get; set; }

    public string? status { get; set; }

    public virtual propertydetails_import? profile { get; set; }
}
