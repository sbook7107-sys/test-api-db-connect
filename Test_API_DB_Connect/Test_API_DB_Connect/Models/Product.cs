using System;
using System.Collections.Generic;

namespace Test_API_DB_Connect.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }
}
