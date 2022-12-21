using System;
using System.Collections.Generic;

namespace WebPortal_v1.Models
{
    public partial class Uzytkownicy
    {
        public uint Id { get; set; }
        public string? Login { get; set; }
        public string? Haslo { get; set; }
    }
}
