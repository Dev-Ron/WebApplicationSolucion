using Core.Entities;
using Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Core.UseCases
{
    public class BussinessLogic : IBussinessLogic
        {
            private readonly IRepositorio Repository;
            public BussinessLogic(IRepositorio Repository)
            {
                this.Repository = Repository;
            }

        public IQueryable<Organismo> ObtenerOrganismosAsync() {

           //Pruebas
            
            //Expression<Func<Organismo, bool>> expr = (Datos) => (Datos.Nombre.Contains("BERNABEU"));

            IQueryable<Organismo> Organismos =  Repository.FindAllQuarable<Organismo>();
            return Organismos;

        }

        public void InsertarOrganismo(string values)
        {
            var Org = new Organismo();
            JsonConvert.PopulateObject(values, Org);
            Repository.Create<Organismo>(Org);
        }

        public void ActualizarOrganismo(int key, string values)
        {
            var Org = Repository.Find<Organismo>(s => s.Id == key);
            JsonConvert.PopulateObject(values, Org);
            Repository.Update2<Organismo>(Org);
        }

        public void KillOrganismo(int key)
        {
            var Org = Repository.Find<Organismo>(s => s.Id == key);
            Repository.Delete<Organismo>(Org);
        }

        public IEnumerable<Tauxpai> ObtenerPaises()
        {
            Expression<Func<Tauxpai, bool>> expr = (Datos) => (Datos.Id != null);
            IEnumerable<Tauxpai> Paises = Repository.FindAll<Tauxpai>(expr);
            return Paises;

        }

        public IEnumerable<Tipodeorganismo> ObtenerTipoOrganismo()
        {
            Expression<Func<Tipodeorganismo, bool>> expr = (Datos) => (Datos.Id != null);
            IEnumerable<Tipodeorganismo> Paises = Repository.FindAll<Tipodeorganismo>(expr);
            return Paises;

        }

       

        public IEnumerable<Comunidadesautonoma> ObtenerComunidades()
        {
            Expression<Func<Comunidadesautonoma, bool>> expr = (Datos) => (Datos.Id != null);
            IEnumerable<Comunidadesautonoma> Paises = Repository.FindAll<Comunidadesautonoma>(expr);
            return Paises;

        }

        public IEnumerable<Provinciaespana> ObtenerProvincias()
        {
            Expression<Func<Provinciaespana, bool>> expr = (Datos) => (Datos.Id != null);
            IEnumerable<Provinciaespana> Paises = Repository.FindAll<Provinciaespana>(expr);
            return Paises;

        }

        public IEnumerable<Subtipoorganismo> ObtenerSubTipoOrganismos()
        {
            Expression<Func<Subtipoorganismo, bool>> expr = (Datos) => (Datos.Id != null);
            IEnumerable<Subtipoorganismo> Paises = Repository.FindAll<Subtipoorganismo>(expr);
            return Paises;

        }

        public IEnumerable<Organismosporpai> ObtenerOrganismosByPais()
        {
            Expression<Func<Organismosporpai, bool>> expr = (Datos) => (Datos.Id != null);
            IEnumerable<Organismosporpai> Paises = Repository.FindAll<Organismosporpai>(expr);
            return Paises;

        }

        public IEnumerable<Organismocontacto> ObtenerContactos(int IdOrganismo)
        {
            Expression<Func<Organismocontacto, bool>> expr = (Datos) => (Datos.Idorganismo == IdOrganismo);
            IEnumerable<Organismocontacto> Paises = Repository.FindAll<Organismocontacto>(expr);
            return Paises;
        }

        public IEnumerable<Organismocuentasbancaria> ObtenerCuentas(int IdOrganismo)
        {
            Expression<Func<Organismocuentasbancaria, bool>> expr = (Datos) => (Datos.Idorganismo == IdOrganismo);
            IEnumerable<Organismocuentasbancaria> Paises = Repository.FindAll<Organismocuentasbancaria>(expr);
            return Paises;
        }
    }
    }
