using System;
using System.Collections.Generic;

namespace Lession10.Models;

public partial class Category
{
    public int CateId { get; set; }

    public string? CateName { get; set; }

    public int? CateStatus { get; set; }
}
