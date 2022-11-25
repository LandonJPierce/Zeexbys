using System;
using System.Collections.Generic;

namespace Zeexbys.Model;

public partial class Menu
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Calories { get; set; }

    public decimal Price { get; set; }

    public int Lethality { get; set; }
}
