using System;
using System.Collections.Generic;

namespace DataBase;

public partial class Zakaz
{
    public string? NameOfProduct { get; set; }

    public string? NumOfProduct { get; set; }

    public int? Price { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? PhoneNumber { get; set; }

    public long Id { get; set; }
}
