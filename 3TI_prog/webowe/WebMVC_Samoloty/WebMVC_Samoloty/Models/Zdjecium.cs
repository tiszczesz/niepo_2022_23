using System;
using System.Collections.Generic;

namespace WebMVC_Samoloty.Models
{
    public partial class Zdjecium
    {
        public uint Id { get; set; }
        public string? NazwaPliku { get; set; }
        public string? Podpis { get; set; }
    }
}
