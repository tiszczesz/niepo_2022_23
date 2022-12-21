using System;
using System.Collections.Generic;

namespace WebPortal_v1.Models
{
    public partial class Dane
    {
        public uint Id { get; set; }
        public short? RokUrodz { get; set; }
        public uint? Przyjaciol { get; set; }
        public string? Hobby { get; set; }
        public string? Zdjecie { get; set; }
    }
}
