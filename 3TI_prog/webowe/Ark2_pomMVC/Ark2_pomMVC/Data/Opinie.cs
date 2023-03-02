using System;
using System.Collections.Generic;

namespace Ark2_pomMVC.Data;

public partial class Opinie
{
    public uint Id { get; set; }

    public uint KlienciId { get; set; }

    public string? Opinia { get; set; }

    public byte? Ocena { get; set; }

    public virtual Klienci Klienci { get; set; } = null!;
}
