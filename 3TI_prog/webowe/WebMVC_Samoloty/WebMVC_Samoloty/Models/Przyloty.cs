using System;
using System.Collections.Generic;

namespace WebMVC_Samoloty.Models
{
    public partial class Przyloty
    {
        public uint Id { get; set; }
        public uint SamolotyId { get; set; }
        public string? NrRejsu { get; set; }
        public string? Kierunek { get; set; }
        public TimeOnly? Czas { get; set; }
        public DateOnly? Dzien { get; set; }
        public string? StatusLotu { get; set; }
    }
}
