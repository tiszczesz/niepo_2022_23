using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC_Samoloty.Models
{
    public partial class Odloty
    {
        public uint Id { get; set; }

        [ForeignKey("Samoloty")]
        public uint SamolotyId { get; set; }
        public string? NrRejsu { get; set; }
        public string? Kierunek { get; set; }
        public TimeOnly Czas { get; set; }
        public DateOnly? Dzien { get; set; }
        public string? StatusLotu { get; set; }

        public Samoloty Samoloty { get; set; }
    }
}
