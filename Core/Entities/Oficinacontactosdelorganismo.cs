using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class Oficinacontactosdelorganismo
    {
        public decimal? Id { get; set; }
        public decimal? Idorganismo { get; set; }
        public decimal? Idoficina { get; set; }
        public decimal? Idcategoria { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }
}
