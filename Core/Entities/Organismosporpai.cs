using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Organismosporpai
    {
        public decimal? Id { get; set; }
        public string Organismo { get; set; }
        public decimal? Idpais { get; set; }
        public string Pais { get; set; }
    }
}
