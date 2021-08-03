using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Core.Entities
{
    public partial class Organismo
    {
        [Key]
        public decimal? Id { get; set; }
        public decimal? Idtipoorganismo { get; set; }
        public decimal? Idpais { get; set; }
        public decimal? Iddependiente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Cp { get; set; }
        public string Poblacion { get; set; }
        public decimal? Idprovincia { get; set; }
        public decimal? Idcomunidad { get; set; }
        public string Cif { get; set; }
        public string Web { get; set; }
        public string Codigo { get; set; }
        public decimal? Idpaisambito { get; set; }
        public DateTime? Fechabaja { get; set; }
        public decimal? Idpasaa { get; set; }
        public string Motivobaja { get; set; }
        public DateTime? Fechaalta { get; set; }
        public string Idsubtipoorganismo { get; set; }
    }
}
