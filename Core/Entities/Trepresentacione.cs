using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Trepresentacione
    {
        public decimal? Id { get; set; }
        public decimal? Idrepresentante { get; set; }
        public decimal? Idrepresentado { get; set; }
        public DateTime? Fechainicio { get; set; }
        public DateTime? Fechafin { get; set; }
    }
}
