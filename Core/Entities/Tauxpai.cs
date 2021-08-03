using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Tauxpai
    {
        public int? Id { get; set; }
        public string Snombre { get; set; }
        public string Sid { get; set; }
        public decimal? Sepa { get; set; }
        public string Iso2 { get; set; }
        public string Iso3 { get; set; }
        public string Isonumber { get; set; }
        public decimal? Iban { get; set; }
        public decimal? Longiban { get; set; }
        public string Urlmatriculas { get; set; }
        public string Sname { get; set; }
    }
}
