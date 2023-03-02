using System;
using System.Collections.Generic;

namespace Ark2_pomMVC.Data;

public partial class Klienci
{
    public uint Id { get; set; }

    public uint TypyId { get; set; }

    public string? Imie { get; set; }

    public string? Nazwisko { get; set; }

    public string? Zdjecie { get; set; }

    public uint? Punkty { get; set; }

    public virtual ICollection<Opinie> Opinies { get; } = new List<Opinie>();

    public virtual Typy Typy { get; set; } = null!;
}
