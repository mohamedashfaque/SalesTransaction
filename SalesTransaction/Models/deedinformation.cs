using System;
using System.Collections.Generic;

namespace SalesTransaction.Models;

public partial class deedinformation
{
    public int id { get; set; }

    public string? sourceuniqueid { get; set; }

    public int? masterid { get; set; }

    public int? profileid { get; set; }

    public decimal? transactionyear { get; set; }

    public string? book { get; set; }

    public string? page { get; set; }

    public string? dateofdeed { get; set; }

    public string? deedtype { get; set; }

    public string? deednumber { get; set; }

    public string? deeddescription { get; set; }

    public string? grantor { get; set; }

    public string? grantee { get; set; }

    public string? saleprice { get; set; }

    public int? countryid { get; set; }

    public int? regionid { get; set; }

    public string? referenceurl { get; set; }

    public DateOnly? createddate { get; set; }

    public DateOnly? modifieddate { get; set; }
}
