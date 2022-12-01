using System;
using System.Collections.Generic;

namespace WebMVC_Samoloty.Models
{
    public partial class Uslugi
    {
        public uint Id { get; set; }
        public uint KadraId { get; set; }
        public uint? Rodzaj { get; set; }
        public string? Nazwa { get; set; }
        public double? Cena { get; set; }
    }
}
