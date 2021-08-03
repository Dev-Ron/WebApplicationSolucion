using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBussinessLogic
    {
        public IQueryable<Organismo> ObtenerOrganismosAsync();

        public IEnumerable<Tauxpai> ObtenerPaises();

        public IEnumerable<Comunidadesautonoma> ObtenerComunidades();

        public IEnumerable<Provinciaespana> ObtenerProvincias();

        public IEnumerable<Subtipoorganismo> ObtenerSubTipoOrganismos();

        public IEnumerable<Organismocontacto> ObtenerContactos(int IdOrganismo);

        public IEnumerable<Organismocuentasbancaria> ObtenerCuentas(int IdOrganismo);

        public IEnumerable<Tipodeorganismo> ObtenerTipoOrganismo();

        public void InsertarOrganismo(string values);

        public void KillOrganismo(int key);

        public void ActualizarOrganismo(int key, string values);
    }
}
