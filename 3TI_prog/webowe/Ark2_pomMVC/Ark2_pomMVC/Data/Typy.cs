using System;
using System.Collections.Generic;

namespace Ark2_pomMVC.Data;

public partial class Typy
{
    public uint Id { get; set; }

    public string? Nazwa { get; set; }

    public virtual ICollection<Klienci> Kliencis { get; } = new List<Klienci>();
}
