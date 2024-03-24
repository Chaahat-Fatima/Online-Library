using System;
using System.Collections.Generic;

namespace Online_Library.Models;

public partial class Table
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string? Genre { get; set; }

    public int? PublicationYear { get; set; }

    public string? Isbn { get; set; }
}
