using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Organismocuentasbancaria
    {
        public decimal? Id { get; set; }
        public decimal? Idorganismo { get; set; }
        public decimal? Idcategoria { get; set; }
        public string Ccc { get; set; }
        public string Swift { get; set; }
        public decimal? Idpais { get; set; }
    }
}
