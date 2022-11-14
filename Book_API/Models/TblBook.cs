using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Book_API.Models;

public partial class TblBook
{
    [Key]
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? AuthorName { get; set; }
}
