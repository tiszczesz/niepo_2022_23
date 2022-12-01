using System;
using System.Collections.Generic;

namespace WebMVC_Samoloty.Models
{
    public partial class Samoloty
    {
        public uint Id { get; set; }
        public string? Typ { get; set; }
        public string? Linie { get; set; }
    }
}
