using System;
using System.Collections.Generic;

namespace BookAPI.Models;

public partial class TblBook
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? AuthorName { get; set; }
}
